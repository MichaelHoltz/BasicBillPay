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
        int paymentItemIndex = 0;
        public CtrlPerson()
        {
            InitializeComponent();
        }
        public CtrlPerson(ref Database database, ref int pii)
        {
            InitializeComponent();
            db = database;
            paymentItemIndex = pii;
        }

        private void CtrlPerson_Load(object sender, EventArgs e)
        {

        }
        private void InitializeCharts()
        {
            chartAccount1.Series.Clear();
            chartAccount1.Series.Add("Account1");
            chartAccount1.Series[0].ChartType = SeriesChartType.Pie;
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
            //Payment p = db.AddPayment(-1, -1, DateTime.Parse("6/15/18"), DateTime.Parse("4/30/2018"), 0.00f);
            Payment p = db.AddPayment(-1, -1, DateTime.Now, DateTime.Now.AddMonths(-1), 0.00f, TransactionPeriod.Monthly);
            //End Tryout
            AddPaymentCtrl(p);
        }
        private void AddPaymentCtrl(Payment p)
        {
            CtrlPayment ctrlPayment = new CtrlPayment(ref db, ref p, paymentItemIndex++);
            ctrlPayment.ItemDeleted += CtrlPayment_ItemDeletedOrIndexChanged;
            ctrlPayment.AccountSelected += CtrlPayment_AccountSelected;
            ctrlPayment.AmountChanged += CtrlPayment_AmountChanged;
            ctrlPayment.IndexChanged += CtrlPayment_ItemDeletedOrIndexChanged;
            if (p.PayFromId == 0)
            {
                flpBills.Controls.Add(ctrlPayment);
                String name = db.GetAccount(p.PayToId).Name;
                float Amount = p.GetMonthlyAmount(p.PaymentAmount);
                AddChartPoint(chartAccount1, name, Amount);
            }
            //else if (p.PayFromId == 1)
            //{
            //    flpBills2.Controls.Add(ctrlPayment);
            //    String name = db.GetAccount(p.PayToId).Name;
            //    float Amount = p.GetMonthlyAmount(p.PaymentAmount);
            //    AddChartPoint(chartAccount2, name, Amount);
            //}
        }
        /// <summary>
        /// Adds a Chart Point only if it doesn't exist, otherwise it updates.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="name"></param>
        /// <param name="Amount"></param>
        private void AddChartPoint(Chart c, String name, float Amount)
        {
            DataPoint dp = new DataPoint(0, Amount);
            dp.IsValueShownAsLabel = true;
            dp.LabelFormat = "C0";
            dp.Name = name;
            dp.LegendText = name;
            dp.LabelToolTip = name; // Amount.ToString("C0");
            dp.LegendToolTip = Amount.ToString("C0");
            DataPoint odp = c.Series[0].Points.FirstOrDefault(o => o.LegendText == name);
            if (odp == null)
            {
                c.Series[0].Points.Add(dp);
            }
            else
            {
                odp = dp;
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
            float split1Total = 0f;
            float split2Total = 0f;
            foreach (BudgetItem bItem in db.BudgetItems)
            {

                BudgetTotal += bItem.GetMonthlyAmount(bItem.Amount);
                split1Total += bItem.GetMonthlyAmount(bItem.Split1Amount);
                split2Total += bItem.GetMonthlyAmount(bItem.Split2Amount);
            }
            tbTotal.Text = db.GetAccountTotal("M Checking", TransactionPeriod.Monthly).ToString("c");

            //tbTotal2.Text = db.GetAccountTotal("C Checking", TransactionPeriod.Monthly).ToString("c");
            //tbBudgetTotal.Text = BudgetTotal.ToString("c");
            //tbSplit1Total.Text = split1Total.ToString("c"); //Account 2 (Reversed)


            tbSplit2Total.Text = split2Total.ToString("c");

            tbTotalBillBudgetAccount1.Text = (db.GetAccountTotal("M Checking", TransactionPeriod.Monthly) + split2Total).ToString("c");
            //tbTotalBillBudgetAccount2.Text = (db.GetAccountTotal("C Checking", TransactionPeriod.Monthly) + split1Total).ToString("c");


        }
        private void CtrlPayment_AccountSelected(object sender, CtrlPayment.AccountSelectedEventArgs e)
        {
            //BudgetItem b = 
            UserControl ca = new CtrlAccount(e.SelectedAccount);
            frmPopup fp = new frmPopup("Account", ref ca, sender as Control);
            fp.ShowDialog();
        }
        private void CtrlPayment_ItemDeletedOrIndexChanged(object sender, EventArgs e)
        {
            if (sender is CtrlSortableBase)
            {
                CtrlSortableBase csb = (sender as CtrlSortableBase);
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
    }
}
