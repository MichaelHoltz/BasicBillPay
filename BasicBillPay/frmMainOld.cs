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

namespace BasicBillPay
{
    public partial class frmMainOld : Form
    {
        Database db = null; 
        ApplicationSettings appSettings = null;
        int paymentItemIndex = 0;
        int budgetItemIndex = 0;
        public frmMainOld()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appSettings = PersistenceBase.Load<ApplicationSettings>(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.bbp"));
            if (appSettings.Password == null)
            {
                //Get Password for settings and data
                UserControl cp = new CtrlPasswordSetup();
                frmPopup fp = new frmPopup("System Password", ref cp, this);
                fp.ShowDialog();
                appSettings.Password = AESGCM.Password;
            }
            else
            {
                AESGCM.Password = appSettings.Password; // Set for Shortened function calls
            }
            //Assign a default path if one doesn't exist.
            if (appSettings.DbPath == null)
            {
                appSettings.DbPath = PersistenceBase.GetAbsolutePath(@"\Data\mybills.bbp");
            }
            
            LoadData();
        }
        private void InitializeCharts()
        {
            Charts.InitializeChart(chartAccount1, "Account1");
            Charts.InitializeChart(chartAccount2, "Account");
            Charts.InitializeChart(chartBudget, "Budget");
        }
        private void InitializeFlowLayout()
        {
            //Add Bill Header for First Account
            CtrlHeader ch = new CtrlHeader();
            flpBills.Controls.Add(ch);

            //Add Bill Header for Second Account
            CtrlHeader ch2 = new CtrlHeader();
            flpBills2.Controls.Add(ch2);


            //Add Budget Header
            CtrlHeader chBudget = new CtrlHeader();
            flpBudget.Controls.Add(chBudget);

        }
        /// <summary>
        /// Function to LoadData
        /// </summary>
        private void LoadData()
        {
            InitializeCharts();
            InitializeFlowLayout();
            //Load the Database
            //db = PersistenceBase.Load<Database>(PersistenceBase.GetAbsolutePath(@"\Data\mybills.json"));
            db = PersistenceBase.Load<Database>(appSettings.DbPath);

            //Income Totals
            float iTotal1 = 0f;
            float iTotal2 = 0f;


            //Need to Load all Controls
            foreach (Payment pItem in db.Payments.OrderBy(o=>o.DateDue))
            {
                
                AddPaymentCtrl(pItem);

                //Need to find transfers from one account to another. (but I have all accounts as the same so need to identify income vs expense)
                if (pItem.PayToId == 1 && pItem.PayFromId == 0) // Stupid hardcoded Transfer
                {
                    iTotal2 += pItem.GetMonthlyAmount(pItem.PaymentAmount);
                }
            }
            foreach (BudgetItem bItem in db.BudgetItems.OrderBy(o=>o.Index))
            {
                AddBudgetCtrl(bItem);
            }

            foreach (Paycheck item in db.PayChecks)
            {
                if (item.Id == 0) // stupid hard coded knowing account ID
                {
                    iTotal1 += item.GetMonthlyAmount(item.NetPayPerPayPeriod); // Get monthly amount
                }
                if (item.Id == 2)
                {
                    iTotal2 += item.GetMonthlyAmount(item.NetPayPerPayPeriod);
                }

            }
            tbIncome1.Text = iTotal1.ToString("c");
            tbIncome2.Text = iTotal2.ToString("c");
            
            CalculateTotals();

        }
        public HashSet<Payment> GetPayments()
        {
            return db.Payments;
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
            tbTotal.Text = db.GetAccountTotal(db.GetAccount("M Checking").Id, TransactionPeriod.Monthly).ToString("c");

            tbTotal2.Text = db.GetAccountTotal(db.GetAccount("C Checking").Id, TransactionPeriod.Monthly).ToString("c");
            tbBudgetTotal.Text = BudgetTotal.ToString("c");
            tbSplit1Total.Text = split1Total.ToString("c"); //Account 2 (Reversed)
            

            tbSplit2Total.Text = split2Total.ToString("c");
            
            tbTotalBillBudgetAccount1.Text = (db.GetAccountTotal(db.GetAccount("M Checking").Id, TransactionPeriod.Monthly) + split2Total).ToString("c");
            tbTotalBillBudgetAccount2.Text = (db.GetAccountTotal(db.GetAccount("C Checking").Id, TransactionPeriod.Monthly) + split1Total).ToString("c");


        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
        private void CtrlBudget_ItemDeleted(object sender, EventArgs e)
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
        private void tbSplit2Total_TextChanged(object sender, EventArgs e)
        {
            Charts.AddChartPoint(chartAccount1, "Budget Split Items", float.Parse(tbSplit2Total.Text, NumberStyles.Currency, null));
        }
        private void tbSplit1Total_TextChanged(object sender, EventArgs e)
        {
            Charts.AddChartPoint(chartAccount1, "Budget Split Items", float.Parse(tbSplit1Total.Text, NumberStyles.Currency, null));
        }

        /// <summary>
        /// Adds a visual Control Linked to the provided Payment
        /// </summary>
        /// <param name="p"></param>
        private void AddPaymentCtrl(Payment p)
        {
            //CtrlPaymentItem ctrlPayment = new CtrlPaymentItem(ref db, ref p, paymentItemIndex++, epGeneral);
            //ctrlPayment.ItemDeleted += CtrlPayment_ItemDeletedOrIndexChanged;
            ////ctrlPayment.AccountSelected += CtrlPayment_AccountSelected;
            //ctrlPayment.AmountChanged += CtrlPayment_AmountChanged;
            //ctrlPayment.IndexChanged += CtrlPayment_ItemDeletedOrIndexChanged;
            //if (p.PayFromId == 0)
            //{
            //    flpBills.Controls.Add(ctrlPayment);
            //    String name = db.GetAccount(p.PayToId).Name;
            //    float Amount = p.GetMonthlyAmount(p.PaymentAmount);
            //    Charts.AddChartPoint(chartAccount1, name, Amount);
                
            //}
            //else if (p.PayFromId == 1)
            //{
            //    flpBills2.Controls.Add(ctrlPayment);
            //    String name = db.GetAccount(p.PayToId).Name;
            //    float Amount = p.GetMonthlyAmount(p.PaymentAmount);
            //    Charts.AddChartPoint(chartAccount2, name, Amount);
            //}
        }



        private void CtrlPayment_AmountChanged(object sender, AmountChangedEventArgs e)
        {
            CalculateTotals();
        }

        private void CtrlPayment_AccountSelected(object sender, AccountSelectedEventArgs e)
        {
            //BudgetItem b = 
            UserControl ca = new CtrlAccount(e.SelectedAccount);
            frmPopup fp = new frmPopup("Account", ref ca, sender as Control);
            fp.ShowDialog();
        }



        /// <summary>
        /// Adds a visual Control Linked to the provided Budget Item
        /// </summary>
        /// <param name="b"></param>
        private void AddBudgetCtrl(BudgetItem b)
        {
            CtrlBudgetItem ctrlBudget = new CtrlBudgetItem(ref b, budgetItemIndex++, db);
            ctrlBudget.ItemDeleted += CtrlBudget_ItemDeleted;
            flpBudget.Controls.Add(ctrlBudget);

            String name = b.Name;
            float Amount = b.GetMonthlyAmount(b.Amount);
            Charts.AddChartPoint(chartBudget, name, Amount);
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {
            //PersistenceBase.Save(PersistenceBase.GetAbsolutePath(@"\Data\mybills.json"), db); // Todo - use app Settings path!!
            PersistenceBase.Save(appSettings.DbPath, db); 
            PersistenceBase.Save(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.bbp"), appSettings);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings fs = new frmSettings(appSettings);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                PersistenceBase.Save(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.bbp"), appSettings);
            }
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmPeopleManager fpm = new frmPeopleManager(ref db);
            fpm.ShowDialog();
        }
    }
}
