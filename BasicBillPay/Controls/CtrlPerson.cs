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
            LoadData();
        }
        /// <summary>
        /// Function to LoadData
        /// </summary>
        private void LoadData()
        {
            InitializeCharts();
            InitializeFlowLayout();

            //Income Totals
            float iTotal1 = 0f;

            //Need to Load all Controls
            foreach (Payment pItem in db.Payments.OrderBy(o => o.DateDue))
            {

                AddPaymentCtrl(pItem);
                //Need to find transfers into one of my accounts
                if (person.AccountIds.Contains(pItem.PayToId))
                {
                    iTotal1 += pItem.GetMonthlyAmount(pItem.PaymentAmount);
                }
            }

            foreach (Paycheck item in db.PayChecks)
            {
                if (person.PaycheckIds.Contains(item.Id)) // One of my Paychecks
                {
                    iTotal1 += item.GetMonthlyAmount(item.NetPayPerPayPeriod); // Get monthly amount
                }

            }
            tbIncome1.Text = iTotal1.ToString("c");

            CalculateTotals();

        }
        private void InitializeCharts()
        {
            Charts.InitializeChart(chartAccount1, "Account1");
        }
        private void InitializeFlowLayout()
        {
            //Add Bill Header for First Account
            CtrlHeader ch = new CtrlHeader();
            flpBills.Controls.Add(ch);
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            ////Add Payment
            //BUG BUG BUG.. not Person ID  I need the Person's Account ID.. (But since they can have more than one account this is going to be a problem.)
            //Payment p = db.AddPayment(-1, -1, DateTime.Parse("6/15/18"), DateTime.Parse("4/30/2018"), 0.00f);
            Payment p = db.AddPayment(-1, person.Id, DateTime.Now, DateTime.Now.AddMonths(-1), 0.00f, TransactionPeriod.Monthly);
            //End Tryout
            AddPaymentCtrl(p);
        }
        private void AddPaymentCtrl(Payment p)
        {
            //Add an account for the New Payment
            if (p.PayToId == -1)
            {
                Account a = db.AddAccount("New Payment", AccountType.Expense, null, null, null);
                p.PayToId = a.Id;
            }


            CtrlPayment ctrlPayment = new CtrlPayment(ref db, ref p, paymentItemIndex++);
            ctrlPayment.ItemDeleted += CtrlPayment_ItemDeleted;
            ctrlPayment.AccountSelected += CtrlPayment_AccountSelected;
            ctrlPayment.AmountChanged += CtrlPayment_AmountChanged;
            //ctrlPayment.IndexChanged += CtrlPayment_ItemDeletedOrIndexChanged;
            //Only Add Accounts this person is paying directly to.
            if (person.AccountIds.Contains( p.PayFromId))
            {
                flpBills.Controls.Add(ctrlPayment);
                String name = db.GetAccount(p.PayToId).Name;
                float Amount = p.GetMonthlyAmount(p.PaymentAmount);
                Charts.AddChartPoint(chartAccount1, name, Amount);

            }
        }
        private void CtrlPayment_AmountChanged(object sender, CtrlPayment.AmountChangedEventArgs e)
        {
            CalculateTotals();
        }
        private void CalculateTotals()
        {
            //TODO - Get Budget Items like Account Total
            float BudgetTotal = 0f;
            float splitTotal = 0f;
            foreach (BudgetItem bItem in db.BudgetItems)
            {

                BudgetTotal += bItem.GetMonthlyAmount(bItem.Amount);
                if(person.AccountIds.Contains(bItem.Split1AccountId))
                    splitTotal += bItem.GetMonthlyAmount(bItem.Split1Amount); // Tied to specific accounts.. need to fix
                if (person.AccountIds.Contains(bItem.Split2AccountId))
                    splitTotal += bItem.GetMonthlyAmount(bItem.Split2Amount);
            }
            float Total = 0f;
            foreach (int item in person.AccountIds)
            {
                
                Total += db.GetAccountTotal(db.GetAccount(item).Name, TransactionPeriod.Monthly);
            }
            tbTotal.Text = Total.ToString("c");

            tbSplitTotal.Text = splitTotal.ToString("c");

            tbTotalBillBudgetAccount1.Text = (Total + splitTotal).ToString("c");


        }
        private void CtrlPayment_AccountSelected(object sender, CtrlPayment.AccountSelectedEventArgs e)
        {
            //BudgetItem b = 
            UserControl ca = new CtrlAccount(e.SelectedAccount);
            frmPopup fp = new frmPopup("Account", ref ca, sender as Control);
            fp.ShowDialog();
            (sender as TextBox).Text = e.SelectedAccount.Name;
            
        }
        private void CtrlPayment_ItemDeleted(object sender, EventArgs e)
        {
            if (sender is CtrlSortableBase)
            {

                CtrlSortableBase csb = (sender as CtrlSortableBase);
                CtrlPayment cp = (sender as CtrlPayment);
                Payment p = cp.GetPayment();
                db.Payments.Remove(p);
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
            Charts.AddChartPoint(chartAccount1, "Budget Split Items", float.Parse(tbSplitTotal.Text, NumberStyles.Currency, null));
        }
    }
}
