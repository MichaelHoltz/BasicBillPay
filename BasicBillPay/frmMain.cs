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
    public partial class frmMain : Form
    {
        Database db = null; 
        ApplicationSettings appSettings = null;
        int paymentItemIndex = 0;
        int budgetItemIndex = 0;
        public frmMain()
        {
            InitializeComponent();
            db = PersistenceBase.Load<Database>(appSettings.DbPath);
            appSettings = PersistenceBase.GetApplicationSettings(this);

        }
        internal frmMain(ApplicationSettings appSettings, Database database)
        {
            InitializeComponent();
            this.appSettings = appSettings;
            db = database;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void InitializeCharts()
        {
            Charts.InitializeChart(chartBudget, "Budget");
        }
        private void InitializeFlowLayout()
        {
            flpBudget.Controls.Clear(); // Remove Anything / Everything

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
            flpPeopleBills.Controls.Clear();

            foreach (Person p in db.People)
            {
                Person rp = p;
                CtrlPerson cp = new CtrlPerson(ref db, ref paymentItemIndex, ref rp);
                flpPeopleBills.Controls.Add(cp);

            }
            //Income Totals
            float iTotal1 = 0f;
            float iTotal2 = 0f;


            //Need to Load all Controls
            foreach (Payment pItem in db.Payments.OrderBy(o => o.DateDue))
            {

                //AddPaymentCtrl(pItem);

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
                if (item.Id == 2) //I think this is wrong also...
                {
                    iTotal2 += item.GetMonthlyAmount(item.NetPayPerPayPeriod);
                }

            }
            //tbIncome1.Text = iTotal1.ToString("c");
            //tbIncome2.Text = iTotal2.ToString("c");
            
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
            tbBudgetTotal.Text = BudgetTotal.ToString("c");
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

        /// <summary>
        /// Adds a visual Control Linked to the provided Budget Item
        /// </summary>
        /// <param name="b"></param>
        private void AddBudgetCtrl(BudgetItem b)
        {
            CtrlBudgetItem ctrlBudget = new CtrlBudgetItem(ref b, budgetItemIndex++);
            ctrlBudget.ItemDeleted += CtrlBudget_ItemDeleted;
            flpBudget.Controls.Add(ctrlBudget);

            String name = b.Name;
            float Amount = b.GetMonthlyAmount(b.Amount);
            Charts.AddChartPoint(chartBudget, name, Amount);
        }

        private void btnAddBudget_Click(object sender, EventArgs e)
        {
            BudgetItem b = db.AddBudgetItem("", 0.0f, TransactionPeriod.Monthly);
            AddBudgetCtrl(b);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {
            PersistenceBase.SaveData(appSettings, db);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmPeopleManager fpm = new frmPeopleManager(ref db);
            fpm.ShowDialog();
        }

        private void systemPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWelcomePassword fwp = new frmWelcomePassword(appSettings, db);
            fwp.ShowDialog();
        }

        private void managePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleManager fpm = new frmPeopleManager(ref db);
            fpm.ShowDialog();
            //Need to refresh all items if Names changed or People were added.
            LoadData();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings fs = new frmSettings(appSettings);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                PersistenceBase.Save(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.bbp"), appSettings);
            }
        }

        private void managePayChecksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPaychecks fpc = new frmPaychecks(db);
            //fpc.ShowDialog();
        }
    }
}
