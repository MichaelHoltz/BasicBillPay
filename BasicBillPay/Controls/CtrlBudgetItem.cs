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
    public partial class CtrlBudgetItem : CtrlSortableBase
    {
        private float Total = 100f;
        private float Split1 = 50f;
        private float Split2 = 50f;
        private float splitPercentage = .5f;
        BudgetItem b;
        public CtrlBudgetItem()
        {
            InitializeComponent();
        }
        public CtrlBudgetItem(ref BudgetItem budgetItem, int itemIndex) : base(itemIndex)
        {
            InitializeComponent();
            //Bind to Source List FIRST
            cbPaidFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));
            b = budgetItem;

            Total = b.Amount;
            Split1 = b.Split1Amount;
            Split2 = b.Split2Amount;



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
            tbAmount.DataBindings.Clear();
            Binding bb = new Binding("Text", b.Amount, "");
            //// Add the delegates to the event.
            bb.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
            bb.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
            tbAmount.DataBindings.Add(bb);

            //Split1Amount
            tbSplit1Amount.DataBindings.Clear();
            Binding bb2 = new Binding("Text", b.Split1Amount, "");
            // Add the delegates to the event.
            bb2.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
            bb2.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
            tbSplit1Amount.DataBindings.Add(bb2);

            ////Split2Amount
            tbSplit2Amount.DataBindings.Clear();
            Binding bb3 = new Binding("Text", b.Split2Amount, "");
            //// Add the delegates to the event.
            bb3.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
            bb3.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
            tbSplit2Amount.DataBindings.Add(bb3);

            //Set in Constructor
            splitPercentage = (Split1 / Total);
            CalculateSplit(0);
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
                    tbSplit1Amount.Text = ((float)Split1).ToString("c");
                    tbSplit2Amount.Text = ((float)Split2).ToString("c");
                    break;
                case 1:
                    //Change Split 2
                    Split2 = Total - Split1;
                    splitPercentage = (Split1 / Total);
                    tbSplit2Amount.Text = ((float)Split2).ToString("c");
                    break;
                case 2:
                    Split1 = Total - Split2;
                    splitPercentage = (Split1 / Total);
                    tbSplit1Amount.Text = ((float)Split1).ToString("c");
                    //Change Split 1
                    break;
            }
        }


        private void tbSplit1Amount_Leave(object sender, EventArgs e)
        {
            Split1 = float.Parse(tbSplit1Amount.Text, NumberStyles.Currency, null);
            tbSplit1Amount.Text = ((float)Split1).ToString("c");
            CalculateSplit(1);
            b.Split1Amount = Split1;
        }

        private void tbSplit2Amount_Leave(object sender, EventArgs e)
        {
            Split2 = float.Parse(tbSplit2Amount.Text, NumberStyles.Currency, null);
            tbSplit2Amount.Text = ((float)Split2).ToString("c");
            b.Split2Amount = Split2;
            CalculateSplit(2);
        }
        private void tbAmount_Leave(object sender, EventArgs e)
        {
            Total = float.Parse(tbAmount.Text, NumberStyles.Currency, null);
            tbAmount.Text = ((float)Total).ToString("c");
            b.Amount = Total;
            CalculateSplit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object cpfSI = cbPaidFrequency.SelectedItem;
            String cpfStr = cbPaidFrequency.SelectedText;
            object cpfSV = cbPaidFrequency.SelectedValue;
        }

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
    }
}
