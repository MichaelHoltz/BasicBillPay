using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Controls;
using BasicBillPay.Models;
using BasicBillPay.Tools;
namespace BasicBillPay
{
    public partial class frmMain : Form
    {
        Database db = null; // new Database();
        int paymentItemIndex = 0;
        int budgetItemIndex = 0;

        public frmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Add Bill Header
            CtrlHeader ch = new CtrlHeader();
            flpBills.Controls.Add(ch);

            //Add Budget Header
            CtrlHeader chBudget = new CtrlHeader();
            flpBudget.Controls.Add(chBudget);

            //Load the Database
            db = PersistenceBase.Load<Database>(PersistenceBase.GetAbsolutePath(@"\Data\mybills.json"));
            //Need to Load all Controls
            foreach (Payment pItem in db.Payments)
            {
                AddPaymentCtrl(pItem);
            }
            foreach (BudgetItem bItem in db.BudgetItems)
            {
                AddBudgetCtrl(bItem);
            }
            CalculateTotals();
           // ctrlDateTimePicker1.BackColor = Color.Red;
            //ctrlDateTimePicker1.Invalidate();


        }
        private void CalculateTotals()
        {
            //float Total = 0f;
            //float Total2 = 0f;
            float BudgetTotal = 0f;
            //foreach (Payment pItem in db.Payments)
            //{
            //    if (pItem.PayFromId == 0)
            //        Total += pItem.PaymentAmount; // Todo-add and account for normalized Payment Frequency
            //    if (pItem.PayFromId == 1)
            //        Total2 += pItem.PaymentAmount; // Todo-add and account for normalized Payment Frequency
            //}
            foreach (BudgetItem bItem in db.BudgetItems)
            {

                BudgetTotal += bItem.Amount; // Todo-add and account for normalized Payment Frequency
            }
            tbTotal.Text = db.GetAccountTotal("M Checking", TransactionPeriod.Monthly).ToString("c");
            tbTotal2.Text = db.GetAccountTotal("C Checking", TransactionPeriod.Monthly).ToString("c");
            tbBudgetTotal.Text = BudgetTotal.ToString("c");

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
        private void Cb_ItemDeleted(object sender, EventArgs e)
        {
            if (sender is CtrlSortableBase)
            {
                CtrlSortableBase csb = (sender as CtrlSortableBase);
                int i = 0;
                foreach (Control c in flpBudget.Controls)
                {
                    if (c is CtrlSortableBase && csb != c)
                    {
                        (c as CtrlSortableBase).UpdateIndex(i++);
                    }
                }
                budgetItemIndex = i;
            }
        }
        /// <summary>
        /// Adds a visual Control Linked to the provided Payment
        /// </summary>
        /// <param name="p"></param>
        private void AddPaymentCtrl(Payment p)
        {
            CtrlPayment cp = new CtrlPayment(ref db, p, paymentItemIndex++);
            cp.ItemDeleted += Cp_ItemDeleted;
            cp.AccountSelected += Cp_AccountSelected;
            cp.AmountChanged += Cp_AmountChanged;
            flpBills.Controls.Add(cp);

        }

        private void Cp_AmountChanged(object sender, CtrlPayment.AmountChangedEventArgs e)
        {
            CalculateTotals();
        }

        private void Cp_AccountSelected(object sender, CtrlPayment.AccountSelectedEventArgs e)
        {
            //BudgetItem b = 
            CtrlAccount ca = new CtrlAccount(e.SelectedAccount);
            frmPopup fp = new frmPopup("Account", ca, sender as Control);
            fp.ShowDialog();
        }



        /// <summary>
        /// Adds a visual Control Linked to the provied Budget Item
        /// </summary>
        /// <param name="b"></param>
        private void AddBudgetCtrl(BudgetItem b)
        {
            CtrlBudget cb = new CtrlBudget(b, budgetItemIndex++);
            cb.ItemDeleted += Cb_ItemDeleted;
            flpBudget.Controls.Add(cb);
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            ////Add Payment
            //Payment p = db.AddPayment(-1, -1, DateTime.Parse("6/15/18"), DateTime.Parse("4/30/2018"), 0.00f);
            Payment p = db.AddPayment(-1, -1, DateTime.Now, DateTime.Now.AddMonths(-1), 0.00f, TransactionPeriod.Monthly);
            //End Tryout
            AddPaymentCtrl(p);
        }
        private void btnAddBudget_Click(object sender, EventArgs e)
        {
            BudgetItem b = db.AddBudgetItem("", 0.0f, TransactionPeriod.Monthly);
            AddBudgetCtrl(b);
        }
        private void Cp_ItemDeleted(object sender, EventArgs e)
        {
            if (sender is CtrlSortableBase)
            {
                CtrlSortableBase csb = (sender as CtrlSortableBase);
                int i = 0;
                foreach (Control c in flpBills.Controls)
                {
                    if (c is CtrlSortableBase && csb != c)
                    {
                        (c as CtrlSortableBase).UpdateIndex(i++);
                    }
                }
                paymentItemIndex = i;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {
            PersistenceBase.Save(PersistenceBase.GetAbsolutePath(@"\Data\mybills.json"), db);
        }



    }
}
