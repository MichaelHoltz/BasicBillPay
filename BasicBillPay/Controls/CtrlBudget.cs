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
       // public event EventHandler BudgetItemDeleted;
        public CtrlBudget()
        {
            InitializeComponent();
        }
        public CtrlBudget(ref Database database, ref int bii)
        {
            InitializeComponent();
            //Bind to Source List FIRST
            cbPayFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));
            
            db = database;
            currentTransactionPeriod = db.BudgetTotalTransactionPeriod;
            cbPayFrequency.Text = currentTransactionPeriod.ToString();
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
           
            //Budget Items can only change from inside this Control
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
        /// <summary>
        /// User adding a Budget Items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBudgetItem_Click(object sender, EventArgs e)
        {
            BudgetItem b = db.AddBudgetItem("New Budget Item" + db.NextBudgetItemId, 0.0f, TransactionPeriod.Monthly);
            AddBudgetItemControl(b);
        }
        private void AddBudgetItemControl(BudgetItem b)
        {
            CtrlBudgetItem ctrlBudgetItem = new CtrlBudgetItem(ref b, budgetItemIndex++, db);
            ctrlBudgetItem.BudgetItemTotalChanged += CtrlBudget_BudgetTotalChanged;
            ctrlBudgetItem.ItemDeleted += CtrlBudget_ItemDeleted;

            this.MinimumSize = new Size(this.MinimumSize.Width, pTopHeader.Height + 5 + (flpBudget.Controls.Count + 1) * ctrlBudgetItem.Height);
            flpBudget.Controls.Add(ctrlBudgetItem);
            String name = b.Name;
            float Amount = b.GetAmount(b.Amount, currentTransactionPeriod);
            Charts.AddChartPoint(chartBudget, name, Amount);
        }

        private void CtrlBudget_BudgetTotalChanged(object sender, BudgetItemTotalChangedEventArgs e)
        {
            //Handle Rename
            if (e.Name != e.PreviousName)
            {
                Charts.RenameChartPoint(chartBudget, e.PreviousName, e.Name);
            }
            UpdateTotals();
            //Charts.AddChartPoint(chartBudget, e.Name, e.BudgetItem.GetAmount(e.BudgetItem.Amount, currentTransactionPeriod));
        }
        private void UpdateTotals()
        {
            float budgetTotal = 0f;
            foreach (BudgetItem bitem in db.BudgetItems)
            {
                Charts.AddChartPoint(chartBudget, bitem.Name, bitem.GetAmount(bitem.Amount, currentTransactionPeriod));
                budgetTotal += bitem.GetAmount(bitem.Amount, currentTransactionPeriod);
            }
            db.BudgetTotal = budgetTotal;
            cctbBudgetTotal.Bind(db, "BudgetTotal"); //Just One way binding.. so not really a point.

        }
        private void CtrlBudget_ItemDeleted(object sender, EventArgs e)
        {
            if (sender is CtrlSortableBase)
            {
                CtrlSortableBase csb = (sender as CtrlSortableBase); //CtrlBudgetItem.
                CtrlBudgetItem cb = (sender as CtrlBudgetItem);
                BudgetItem b = cb.GetBudgetItem(); // Get the budget Item in the Control
                db.BudgetItems.Remove(b);
                Person p1 = db.GetPerson(b.Split1AccountId); // Split 1 Person
                Person p2 = db.GetPerson(b.Split2AccountId); // Split 2 Person
                Charts.RemoveChartPoint(chartBudget, b.Name); // Removes from Budget Control - TODO - Needs to be removed from charts of p1 and p2.
                //BudgetItemDeleted?.Invoke(sender, new EventArgs());
                //Shrink the Flow layout panel
                this.MinimumSize = new Size(this.MinimumSize.Width, pTopHeader.Height + 5 + (flpBudget.Controls.Count - 1) * csb.Height);
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


        private void cbPayFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPayFrequency.SelectedIndex > -1 && db != null)
            {
                currentTransactionPeriod = (TransactionPeriod)Enum.Parse(typeof(TransactionPeriod), cbPayFrequency.Text);
                cbPayFrequency.Text = currentTransactionPeriod.ToString();
                db.BudgetTotalTransactionPeriod = currentTransactionPeriod;
                UpdateTotals();
                //    CalculateTotals(currentTransactionPeriod);
            }
        }

        private void addTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Transfer not implemented yet.");
        }
    }
}
