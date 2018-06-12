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
        TransactionPeriod currentTransactionPeriod = TransactionPeriod.Monthly; // Default Period
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
            cbPaidFrequency.Text = currentTransactionPeriod.ToString();
            db = database;
            paymentItemIndex = pii;
            this.person = person;
        }

        private void CtrlPerson_Load(object sender, EventArgs e)
        {
            String ending = "'s Bills";
            if (person.Name.EndsWith("s"))
            {
                ending = "' Bills";
            }
            lblAccount1.Text = person.Name + ending;
            cctbTotalIncome.Bind(db.MyBudgetTotal(person.Id)); //One WayBind..
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
            CalculateTotals(currentTransactionPeriod);
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
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            ////Add Payment
            // Big problem if they don't have an account.. They should always have one though, also the first account MUST be an income account
            int firstAccountId = person.AccountIds.FirstOrDefault(); 
            Account a = db.GetAccount(firstAccountId);
            //Minus 1 indicates a new Account.. Which Means Transfers from one existing income account to another will not be possible (nor will use of orphaned expense accounts).
            Payment p = db.AddPayment(-1, a.Id, DateTime.Now, DateTime.Now.AddMonths(-1), 0.00f, TransactionPeriod.Monthly);
            AddPaymentCtrl(p);
            CalculateTotals(currentTransactionPeriod);
        }
        private void AddPaymentCtrl(Payment p)
        {
            //Add an account for the New Payment
            if (p.PayToId == -1)
            {
                Account a = db.AddAccount("New Payment", AccountType.Expense, null, null, null);
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
            CalculateTotals(currentTransactionPeriod);
        }
        private void CalculateTotals(TransactionPeriod transactionPeriod)
        {
            //Add Up Total Bills from all accounts.. 
            float TotalBills = 0f;
            //Person has Income accounts..
            foreach (int item in person.AccountIds)
            {
                //TODO - Make sure they are Expense Accounts.
                TotalBills += db.GetAccountTotal(db.GetAccount(item).Id, transactionPeriod);
            }
            tbTotalBills.Text = TotalBills.ToString("c");


            //Income Totals
            float iTotal1 = 0f;
            //For Each Payment
            //Need to find transfers into one of my accounts (TODO- Make a special Transfer. Could be Income Account to Income Account or Income Account to Paycheck)
            foreach (Payment pItem in db.Payments.OrderBy(o => o.DateDue))
            {
                //Only Add Accounts this person is paying directly to.
                if (person.AccountIds.Contains(pItem.PayFromId))
                {
                    String name = db.GetAccount(pItem.PayToId).Name;
                    float Amount = pItem.GetAmount(pItem.PaymentAmount, transactionPeriod);
                    Charts.AddChartPoint(chartAccount1, name, Amount);

                }

                if (person.AccountIds.Contains(pItem.PayToId))
                {
                    iTotal1 += pItem.GetAmount(pItem.PaymentAmount, transactionPeriod); //Can't create this by app at this time see TODO
                }
            }
            //Add up Paycheck Amounts
            foreach (Paycheck item in db.PayChecks)
            {
                if (person.PaycheckIds.Contains(item.Id)) // One of my Paychecks
                {
                    iTotal1 += item.GetAmount(item.NetPayPerPayPeriod, transactionPeriod); // Get Scaled amount
                }

            }
            tbTotalIncome.Text = iTotal1.ToString("c");

            //TransactionPeriod transactionPeriod = TransactionPeriod.Monthly;
            //TODO - Get Budget Items like Account Total
            float BudgetTotal = 0f;
            //Split of this Person.
            float splitTotal = db.MyBudgetTotal(person.Id);
            //foreach (BudgetItem bItem in db.BudgetItems)
            //{

            //    BudgetTotal += bItem.GetAmount(bItem.Amount, transactionPeriod); //Get Scaled Budget
            //    if (person.Id == bItem.Split1AccountId)
            //        splitTotal += bItem.GetAmount(bItem.Split1Amount, transactionPeriod); // Tied to specific accounts.. need to fix
            //    if (person.Id == bItem.Split2AccountId)
            //        splitTotal += bItem.GetAmount(bItem.Split2Amount, transactionPeriod);
            //}
            tbSplitTotal.Text = splitTotal.ToString("c");
            Charts.AddChartPoint(chartAccount1, "Budget", splitTotal); // Add Budget to the Chart

            Single totalBillsAndBudget = TotalBills + splitTotal;
            //Bills plus budget items for this person.
            tbTotalBillBudgetAccount1.Text = totalBillsAndBudget.ToString("c");

            //Calculate What's left
            Single whatsLeft = iTotal1 - totalBillsAndBudget;
            tbSavings.Text = whatsLeft.ToString("c");
            tbSavings.ForeColor = whatsLeft > 0 ? SystemColors.WindowText : Color.Red; //Conditional Red
            Charts.AddChartPoint(chartAccount1, "What's Left", whatsLeft); // Add Budget to the Chart

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
            }
        }

        private void tbSplitTotal_TextChanged(object sender, EventArgs e)
        {
            //Charts.AddChartPoint(chartAccount1, "Budget Split Items", float.Parse(tbSplitTotal.Text, NumberStyles.Currency, null));
        }

        private void btnPayCheck_Click(object sender, EventArgs e)
        {
            frmPaychecks fpc = new frmPaychecks(db, person);
            fpc.ShowDialog();

            //Need to refresh if they added or changed their paycheck.
            CalculateTotals(currentTransactionPeriod); 
        }

        private void cbPaidFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaidFrequency.SelectedIndex > -1 && person != null)
            {
                currentTransactionPeriod = (TransactionPeriod)Enum.Parse(typeof(TransactionPeriod), cbPaidFrequency.Text);
                cbPaidFrequency.Text = currentTransactionPeriod.ToString();
                CalculateTotals(currentTransactionPeriod);
            }
        }

        private void addTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Transfer not implemented yet.");
        }
    }
}
