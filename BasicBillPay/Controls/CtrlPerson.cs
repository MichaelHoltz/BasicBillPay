using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BasicBillPay.Controls;
using BasicBillPay.Models;
using BasicBillPay.Tools;
using BasicBillPay.Tools.Encryption;
using System.Security;
using System.Security.Cryptography;
using System.Globalization;

namespace BasicBillPay.Controls
{
    public partial class CtrlPerson : UserControl
    {
        Database db = null;
        Person person = null;
        int paymentItemIndex = 0;
        public CtrlPerson()
        {
            InitializeComponent();
        }
        public CtrlPerson(ref Database database, ref int pii, ref Person person)
        {
            InitializeComponent();
            //Bind to Source List FIRST
            cbPaidFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));
            cbPaidFrequency.Text =  person.TotalsTransactionPeriod.ToString();
            db = database;
            paymentItemIndex = pii;
            this.person = person;
            this.person.PropertyChanged += Person_PropertyChanged;
        }
        /// <summary>
        /// One of the Person's properties Changed..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Property Changes come from PayCheck Change, Payment Change, and Budget Change.
            switch (e.PropertyName)
            {
                default:
                    break;
            }
        }

        private void CtrlPerson_Load(object sender, EventArgs e)
        {
            lblPerson.Text = Conversion.Pluralize(person.Name) + " Bills";
            cctbTotalIncome.Bind(db.GetTotalIncome(person)); //One WayBind.. and set
            LoadData();
        }
        /// <summary>
        /// Function to LoadData
        /// </summary>
        private void LoadData()
        {
            InitializeCharts();
            InitializeFlowLayout();
            //Need to Load all Controls and order by due date.
            foreach (Payment pItem in db.Payments.OrderBy(o => o.DateDue))
            {
                AddPaymentCtrl(pItem);
            }
            CalculateTotals(person.TotalsTransactionPeriod);
        }
        
        private void InitializeCharts()
        {
            Charts.InitializeChart(chartAccount1, "Account1");
        }
        private void InitializeFlowLayout()
        {
            //CtrlPayment firstPayment = flpBills.Controls.OfType<CtrlPayment>().FirstOrDefault();
            List<HeaderItem> headerItems = new CtrlPaymentItem().GetHeaderItems();
            //Add Bill Header for First Account
            CtrlHeader ch = new CtrlHeader(headerItems);
            flpBills.Controls.Add(ch);
            flpBills.Controls.SetChildIndex(ch, 0); // Put at the top..
        }
        private void CalculateTotals(TransactionPeriod transactionPeriod)
        {
            //Income Totals
            float iTotal = db.GetTotalIncome(person);
            tbTotalIncome.Text = iTotal.ToString("c");

            //Bills / Payments Total 
            float totalBills = db.GetTotalBills(person);
            tbTotalBills.Text = totalBills.ToString("C");


            //For Each Payment
            //Need to find transfers into one of my accounts (TODO- Make a special Transfer. Could be Income Account to Income Account or Income Account to Paycheck)
            foreach (Payment pItem in db.Payments.OrderBy(o => o.DateDue))
            {
                //Only Add Bill Accounts this person is paying directly to.
                if (person.AccountIds.Contains(pItem.PayFromId))
                {
                    String name = db.GetAccount(pItem.PayToId).Name;
                    float Amount = pItem.GetAmount(pItem.PaymentAmount, transactionPeriod);
                    Charts.AddChartPoint(chartAccount1, name, Amount);

                }
            }

            //Split of this Person.
            float splitTotal = db.GetBudgetTotal(person);
            tbSplitTotal.Text = splitTotal.ToString("c");
            Charts.AddChartPoint(chartAccount1, "Budget", splitTotal); // Add Budget to the Chart

            Single totalBillsAndBudget = totalBills + splitTotal;
            //Bills plus budget items for this person.
            tbTotalBillBudgetAccount1.Text = totalBillsAndBudget.ToString("c");

            //Calculate What's left
            Single whatsLeft = iTotal - totalBillsAndBudget;
            tbSavings.Text = whatsLeft.ToString("c");
            tbSavings.ForeColor = whatsLeft > 0 ? SystemColors.WindowText : Color.Red; //Conditional Red
            Charts.AddChartPoint(chartAccount1, "What's Left", whatsLeft); // Add Budget to the Chart

        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            ////Add Payment
            // Big problem if they don't have an account.. They should always have one though, also the first account MUST be an income account
            int firstAccountId = person.AccountIds.FirstOrDefault(); 
            Account a = db.GetAccount(firstAccountId);
            //Minus 1 indicates a new Account.. Which Means Transfers from one existing income account to another will not be possible (nor will use of orphaned expense accounts).
            Payment p = db.AddPayment(-1, a.Id, DateTime.Now, DateTime.Now.AddMonths(-1), 0.00f, TransactionPeriod.Monthly);
            AddPaymentCtrl(p);
            CalculateTotals(person.TotalsTransactionPeriod);
        }
        private void AddPaymentCtrl(Payment p)
        {
            //Add an account for the New Payment
            if (p.PayToId == -1)
            {
                Account a = db.AddAccount("New Payment " + db.NextPaymentId, AccountType.Expense, null, null, null);
                p.PayToId = a.Id;
            }


            //Only Add Accounts this person is paying directly to.
            if (person.AccountIds.Contains( p.PayFromId))
            {
                CtrlPaymentItem ctrlPayment = new CtrlPaymentItem(ref db, ref p, paymentItemIndex++);
                this.MinimumSize = new Size(this.MinimumSize.Width, pTopHeader.Height + 5 + (flpBills.Controls.Count + 1) * ctrlPayment.Height);
                flpBills.Controls.Add(ctrlPayment);
                ctrlPayment.ItemDeleted += CtrlPayment_ItemDeleted;
                ctrlPayment.AmountChanged += CtrlPayment_AmountChanged;
                
            }
        }
        private void CtrlPayment_AmountChanged(object sender, CtrlPaymentItem.AmountChangedEventArgs e)
        {
            CalculateTotals(person.TotalsTransactionPeriod);
        }


        private void CtrlPayment_ItemDeleted(object sender, EventArgs e)
        {
            if (sender is CtrlSortableBase)
            {

                CtrlSortableBase csb = (sender as CtrlSortableBase);
                CtrlPaymentItem cp = (sender as CtrlPaymentItem);
                Payment p = cp.GetPayment();
                db.Payments.Remove(p);
                String name = db.GetAccount(p.PayToId).Name;
                Charts.RemoveChartPoint(chartAccount1, name);
                this.MinimumSize = new Size(this.MinimumSize.Width, pTopHeader.Height + 5 + (flpBills.Controls.Count - 1) * csb.Height);
                //WARNING - need to make sure the Account isn't being used by other payments and is an Expense Account
                Account a = db.GetAccount(p.PayToId);
                if(a.Type == AccountType.Expense)
                    db.Accounts.Remove(db.GetAccount(p.PayToId));
                //Need to know which Payment was Deleted.
                int i = 0;
                foreach (Control c in flpBills.Controls)
                {
                    if (c is CtrlSortableBase && csb != c) // Doesn't equal Self
                    {
                        (c as CtrlSortableBase).UpdateIndex(i++);
                    }
                }
                paymentItemIndex = i++;
                CalculateTotals(person.TotalsTransactionPeriod);
            }
        }

        private void btnPayCheck_Click(object sender, EventArgs e)
        {
            frmPaychecks fpc = new frmPaychecks(db, person);
            fpc.ShowDialog();

            //Need to refresh if they added or changed their paycheck.
            CalculateTotals(person.TotalsTransactionPeriod);  //Causes major flashing..
        }

        private void cbPaidFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaidFrequency.SelectedIndex > -1 && person != null)
            {
                person.TotalsTransactionPeriod = (TransactionPeriod)Enum.Parse(typeof(TransactionPeriod), cbPaidFrequency.Text);
                cbPaidFrequency.Text = person.TotalsTransactionPeriod.ToString();
                CalculateTotals(person.TotalsTransactionPeriod);
            }
        }

        private void addTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Transfer not implemented yet.");
        }
    }
}
