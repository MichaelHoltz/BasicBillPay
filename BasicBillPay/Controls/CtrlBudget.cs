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
    public partial class CtrlBudget : UserControl
    {
        Database db = null;
        TransactionPeriod currentTransactionPeriod = TransactionPeriod.Monthly; // Default Period
        int budgetItemIndex = 0;
        public event EventHandler BudgetItemChanged;
        public event EventHandler BudgetItemDeleted;
        public CtrlBudget()
        {
            InitializeComponent();
        }
        public CtrlBudget(ref Database database, ref int bii)
        {
            InitializeComponent();
            //Bind to Source List FIRST
            cbPayFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));
            cbPayFrequency.Text = currentTransactionPeriod.ToString();
            db = database;
            budgetItemIndex = bii;
        }

        private void CtrlBudget_Load(object sender, EventArgs e)
        {
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
            foreach (BudgetItem bItem in db.BudgetItems.OrderBy(o => o.Index))
            {
                AddBudgetItemControl(bItem);
            }
           // CalculateTotals(currentTransactionPeriod);
            cctbBudgetTotal.Bind(db, "BudgetTotal"); //Just One way binding.. so not really a point.
            
        }
        
        private void InitializeCharts()
        {
            Charts.InitializeChart(chartBudget, "Account1");
        }
        private void InitializeFlowLayout()
        {
            //CtrlPayment firstPayment = flpBills.Controls.OfType<CtrlPayment>().FirstOrDefault();
            List<HeaderItem> headerItems = new CtrlBudgetItem().GetHeaderItems(); 
            //Add Bill Header for First Account
            CtrlHeader ch = new CtrlHeader(headerItems);
            flpBudget.Controls.Add(ch);
            flpBudget.Controls.SetChildIndex(ch, 0); // Put at the top..
        }
        private void btnAddBudgetItem_Click(object sender, EventArgs e)
        {
            ////Add Payment
            // Big problem if they don't have an account.. They should always have one though, also the first account MUST be an income account
            int firstAccountId = 0; // person.AccountIds.FirstOrDefault(); 
            Account a = db.GetAccount(firstAccountId);
            BudgetItem b = db.AddBudgetItem("New Budget Item" + db.NextBudgetItemId, 0.0f, TransactionPeriod.Monthly);
            AddBudgetItemControl(b);
            CalculateTotals(currentTransactionPeriod);
        }
        private void CalculateTotals(TransactionPeriod transactionPeriod)
        {
            //TODO - Get Budget Items like Account Total
            float BudgetTotal = 0f;
            float split1Total = 0f;
            float split2Total = 0f;
            foreach (BudgetItem bItem in db.BudgetItems)
            {
                BudgetTotal += bItem.GetAmount(bItem.Amount, transactionPeriod);
                split1Total += bItem.GetAmount(bItem.Split1Amount, transactionPeriod);
                split2Total += bItem.GetAmount(bItem.Split2Amount, transactionPeriod);
            }
            cctbBudgetTotal.Value = BudgetTotal;
            //cctbBudgetTotal.Text = BudgetTotal.ToString("C"); //Setting the Text of the user Control does nothing!!! Duh!!
        }
        private void AddBudgetItemControl(BudgetItem b)
        {
            CtrlBudgetItem ctrlBudget = new CtrlBudgetItem(ref b, budgetItemIndex++, db);
            ctrlBudget.BudgetTotalChanged += CtrlBudget_BudgetTotalChanged;
            //ctrlBudget.ItemDeleted += CtrlBudget_ItemDeleted;
            this.MinimumSize = new Size(this.MinimumSize.Width, pTopHeader.Height + 5 + (flpBudget.Controls.Count + 1) * ctrlBudget.Height);
            flpBudget.Controls.Add(ctrlBudget);
            String name = b.Name;
            float Amount = b.GetAmount(b.Amount, currentTransactionPeriod);
            Charts.AddChartPoint(chartBudget, name, Amount);
        }

        private void CtrlBudget_BudgetTotalChanged(object sender, EventArgs e)
        {
            cctbBudgetTotal.Bind(db, "BudgetTotal"); //Just One way binding.. so not really a point.
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
        private void tbSplitTotal_TextChanged(object sender, EventArgs e)
        {
            //Charts.AddChartPoint(chartAccount1, "Budget Split Items", float.Parse(tbSplitTotal.Text, NumberStyles.Currency, null));
        }


        private void cbPaidFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbPaidFrequency.SelectedIndex > -1 && person != null)
            //{
            //    currentTransactionPeriod = (TransactionPeriod)Enum.Parse(typeof(TransactionPeriod), cbPaidFrequency.Text);
            //    cbPaidFrequency.Text = currentTransactionPeriod.ToString();
            //    CalculateTotals(currentTransactionPeriod);
            //}
        }

        private void addTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Transfer not implemented yet.");
        }
    }
}
