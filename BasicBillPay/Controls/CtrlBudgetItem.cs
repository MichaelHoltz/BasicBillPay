using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Models;
using System.Globalization;
using BasicBillPay.Tools;
namespace BasicBillPay.Controls
{
    internal partial class CtrlBudgetItem : CtrlSortableBase
    {
        private float Total = 100f;
        private float Split1 = 50f;
        private float Split2 = 50f;
        private float splitPercentage = 1f;
        BudgetItem b;
        Database databaseFunctions;
        public event EventHandler BudgetTotalChanged;
        public event EventHandler BudgetSplitChanged;
        bool updatingds1 = false;
        bool updatingds2 = false;
        public CtrlBudgetItem()
        {
            InitializeComponent();
        }
        public CtrlBudgetItem(ref BudgetItem budgetItem, int itemIndex, Database database) : base(itemIndex)
        {
            InitializeComponent();
            //Bind to Source List FIRST
            cbPaidFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));


            

            b = budgetItem;
            b.PropertyChanged -= BudgetItem_PropertyChanged; //Remove first pattern.
            b.PropertyChanged += BudgetItem_PropertyChanged;

            base.ReorderIndexes -= CtrlBudgetItem_ReorderIndexes; // Remove first Pattern
            base.ReorderIndexes += CtrlBudgetItem_ReorderIndexes;
            Total = b.Amount;
            Split1 = b.Split1Amount;
            Split2 = b.Split2Amount;
            tbName.BackColor = BackColor;
            cbbSplit1Account.BackColor = BackColor; //Does nothing at this time
            cbbSplit2Account.BackColor = BackColor; //Does nothing at this time
            databaseFunctions = database;

            //For Mutual Exclusion
            cbbSplit1Account.DataSource = new List<Person>(); // Needed in this order
            cbbSplit2Account.DataSource = new List<Person>(); //Needed in this order
            updatingds1 = updatingds2 = true;
            cbbSplit1Account.DataSource = databaseFunctions.GetPeople(true);
            cbbSplit2Account.DataSource = databaseFunctions.GetPeople(true); //Want mutual exclusion so that the same person can't be selected for both.
            updatingds1 = updatingds2 = false;

        }

        private void CtrlBudgetItem_ReorderIndexes(object sender, EventArgs e)
        {
            b.Index = ItemIndex;
        }

        private void BudgetItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Amount":
                    if (Total != b.Amount)
                    {
                        Total = b.Amount;
                        CalculateSplit(0);
                        BudgetTotalChanged?.Invoke(this, new EventArgs());
                    }
                    break;
                case "Split1Amount":
                    if (Split1 != b.Split1Amount)
                    {
                        Split1 = b.Split1Amount;
                        CalculateSplit(1);
                        BudgetSplitChanged?.Invoke(this, new EventArgs());
                    }
                    break;
                case "Split2Amount":
                    if (Split2 != b.Split2Amount)
                    {
                        Split2 = b.Split2Amount;
                        CalculateSplit(2);
                        BudgetSplitChanged?.Invoke(this, new EventArgs());
                    }
                    break;
                default:
                    break;
            }
        }

        private void CtrlBudget_Load(object sender, EventArgs e)
        {

            //Budget Item Name
            tbName.DataBindings.Clear();
            tbName.DataBindings.Add("Text", b.Name, "");

            //Couldn't get Binding to work right so doing it manually
            cbPaidFrequency.Text = b.PayPeriod.ToString();
            //cbPaidFrequency.DataBindings.Clear();
            //cbPaidFrequency.DataBindings.Add("SelectedItem", b, "PaidFrequency"); //Issues
            //cbPaidFrequency.DataBindings.Add("SelectedText", b.PaidFrequency.ToString(), "");
            //cbPaidFrequency.DisplayMember

            //Total Budget Amount
            cctbAmount.Bind(b, "Amount");

            //Split1Amount
            cctbSplit1Amount.Bind(b, "Split1Amount");
            Person p1 = databaseFunctions.GetPerson(b.Split1AccountId);
            if (p1 != null)
            {
                cbbSplit1Account.Text = p1.Name;
                //tbSplit1Account.DataBindings.Clear();
                //tbSplit1Account.DataBindings.Add("Text", p1, "");
            }

            ////Split2Amount
            cctbSplit2Amount.Bind(b, "Split2Amount");
            
            Person p2 = databaseFunctions.GetPerson(b.Split2AccountId);
            if (p2 != null)
            {
                cbbSplit2Account.Text = p2.Name;
//                tbSplit2Account.DataBindings.Clear();
//                tbSplit2Account.DataBindings.Add("Text", p2, "");
            }


            //Set in Constructor
            if (Total == 0)
                splitPercentage =1f;
            else
                splitPercentage = (Split1 / Total);
            CalculateSplit(0);
        }

        public List<HeaderItem> GetHeaderItems()
        {
            List<HeaderItem> retVal = new List<HeaderItem>();
            //Want to order by Tab Index
            foreach (Control item in Controls.OfType<Control>().OrderBy(o => o.TabIndex))
            {
                if (item.Tag.ToString() != "Ignore")
                {
                    HeaderItem hi = new HeaderItem();
                    hi.Title = item.Tag.ToString(); // 
                    hi.Width = item.Width;
                    hi.SourceLeft = item.Left;

                    retVal.Add(hi);
                }
            }
            return retVal;
        }



        /// <summary>
        /// Zero is based on Total Changing
        /// 1 is Split1
        /// 2 is Split2
        /// </summary>
        /// <param name="lastCtrl"></param>
        private void CalculateSplit(int lastCtrl = 0)
        {

            switch (lastCtrl)
            {
                case 0:
                    //Use Percentages and adjust both values
                    //Change both Split1 and Split2
                    Split1 = (splitPercentage * Total);
                    Split2 = Total - Split1; //The Rest..
                    cctbSplit1Amount.Text = ((float)Split1).ToString("c");
                    cctbSplit2Amount.Text = ((float)Split2).ToString("c");
                    b.Split1Amount = Split1;
                    b.Split2Amount = Split2;
                    break;
                case 1:
                    //Change Split 2
                    Split2 = Total - Split1;
                    if (Total == 0)
                        splitPercentage = 1f;
                    else
                        splitPercentage = (Split1 / Total);
                    cctbSplit2Amount.Text = ((float)Split2).ToString("c");
                    b.Split2Amount = Split2;
                    break;
                case 2:
                    Split1 = Total - Split2;
                    if (Total == 0)
                        splitPercentage = 1f;
                    else
                        splitPercentage = (Split1 / Total);
                    cctbSplit1Amount.Text = ((float)Split1).ToString("c");
                    b.Split1Amount = Split1;
                    //Change Split 1
                    break;
            }
        }

        public BudgetItem GetBudgetItem()
        {
            return b;
        }
        //private void cctbSplit1Amount_Leave(object sender, EventArgs e)
        //{
        //   // CalculateSplit(1);
        //}

        //private void cctbSplit2Amount_Leave(object sender, EventArgs e)
        //{
        //  //  CalculateSplit(2);
        //}

        //private void cctbAmount_Leave(object sender, EventArgs e)
        //{
        //   // CalculateSplit(0);
        //}
        ////private void tbSplit1Amount_Leave(object sender, EventArgs e)
        ////{
        ////    Split1 = float.Parse(tbSplit1Amount.Text, NumberStyles.Currency, null);
        ////    tbSplit1Amount.Text = ((float)Split1).ToString("c");
        ////    CalculateSplit(1);
        ////    b.Split1Amount = Split1;
        ////}

        ////private void tbSplit2Amount_Leave(object sender, EventArgs e)
        ////{
        ////    Split2 = float.Parse(tbSplit2Amount.Text, NumberStyles.Currency, null);
        ////    tbSplit2Amount.Text = ((float)Split2).ToString("c");
        ////    b.Split2Amount = Split2;
        ////    CalculateSplit(2);
        ////}
        ////private void tbAmount_Leave(object sender, EventArgs e)
        ////{
        ////    Total = float.Parse(tbAmount.Text, NumberStyles.Currency, null);
        ////    tbAmount.Text = ((float)Total).ToString("c");
        ////    b.Amount = Total;
        ////    CalculateSplit(0);
        ////}

        private void cbPaidFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPaidFrequency.SelectedIndex > -1 && b!=null)
            {
                b.PayPeriod = (TransactionPeriod)Enum.Parse(typeof(TransactionPeriod), cbPaidFrequency.Text);
                cbPaidFrequency.Text = b.PayPeriod.ToString();
                ColorCodePayPeriod();
            }
        }
        private void ColorCodePayPeriod()
        {
            switch (b.PayPeriod)
            {
                case TransactionPeriod.Hourly:
                    break;
                case TransactionPeriod.Daily:
                    break;
                case TransactionPeriod.Weekly:
                    break;
                case TransactionPeriod.Biweekly:
                    cbPaidFrequency.BackColor = Color.LightGreen;
                    break;
                case TransactionPeriod.Monthly:
                    cbPaidFrequency.BackColor = Color.LightBlue;
                    break;
                case TransactionPeriod.Yearly:
                    cbPaidFrequency.BackColor = Color.LightYellow;
                    break;
                default:
                    break;
            }
        }

        private void cbPaidFrequency_DrawItem(object sender, DrawItemEventArgs e)
        {

            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based 
            // on the index of the item to draw.
            switch (e.Index)
            {
                case 0:
                    myBrush = Brushes.Red;
                    
                    break;
                case 1:
                    myBrush = Brushes.Orange;
                    break;
                case 2:
                    myBrush = Brushes.Purple;
                    break;
            }
            // Draw the background of the ListBox control for each item.
            //e.DrawBackground();
            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            e.Graphics.DrawString(cbPaidFrequency.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void cbbSplit1Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSplit1Account.SelectedIndex >= 0 && !updatingds1)
            {
                Person p = cbbSplit1Account.SelectedItem as Person;
                //if (!String.IsNullOrEmpty(p.Name))
                //{
                if (!Conversion.ListsContainSameItems<Person>(cbbSplit2Account.DataSource as List<Person>, databaseFunctions.GetPeople(true, p)))
                {
                    updatingds2 = true;
                    Person p2 = cbbSplit2Account.SelectedItem as Person;
                    cbbSplit2Account.DataSource = databaseFunctions.GetPeople(true, p); //Want mutual exclusion so that the same person can't be selected for both.
                    cbbSplit2Account.SelectedItem = p2;
                    updatingds2 = false;
                }
                
               // }
                b.Split1AccountId = p.Id;
            }
        }

        private void cbbSplit2Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSplit2Account.SelectedIndex >= 0 && !updatingds2)
            {
                Person p = cbbSplit2Account.SelectedItem as Person;
                //if (!String.IsNullOrEmpty(p.Name))
                //{
                    if (!Conversion.ListsContainSameItems<Person>(cbbSplit1Account.DataSource as List<Person>, databaseFunctions.GetPeople(true, p)))
                    {
                        updatingds1 = true;
                        Person p1 = cbbSplit1Account.SelectedItem as Person; //Save Selected Person
                        cbbSplit1Account.DataSource = databaseFunctions.GetPeople(true, p); //Want mutual exclusion so that the same person can't be selected for both.
                        cbbSplit1Account.SelectedItem = p1;
                         updatingds1 = false;
                    }
                    
                //}
                b.Split2AccountId = p.Id;
            }
        }
    }
}
