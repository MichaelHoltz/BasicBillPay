using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Models;
using BasicBillPay.Controls;
namespace BasicBillPay
{
    public partial class frmSplitItemTest : Form
    {
        private float Total = 100f;
        private float Split1 = 50f;
        private float Split2 = 50f;
        private float splitPercentage = .5f;
        public frmSplitItemTest()
        {
            InitializeComponent();

        }
        private void frmSplitItemTest_Load(object sender, EventArgs e)
        {
            tbTotal.Text = Total.ToString("c");
            tbSplit1.Text = Split1.ToString("c");
            tbSplit2.Text = Split2.ToString("c");
            splitPercentage = (Split1 / Total);
            CalculateSplit(0);
            BudgetItem bi = new BudgetItem();
            bi.Name = "Test Item";
            bi.PaidFrequency = TransactionPeriod.Monthly;
            bi.Amount = 300f;
            bi.Split1Amount = 100f;
            bi.Split2Amount = 200f;

            CtrlBudget cb = new CtrlBudget(bi, 0);
            flowLayoutPanel1.Controls.Add(cb);
           
        }
        /// <summary>
        /// Zero is based on Total Changing
        /// 1 is Split1
        /// 2 is Split2
        /// </summary>
        /// <param name="lastCtrl"></param>
        private void CalculateSplit(int lastCtrl =0)
        {
            
            switch (lastCtrl)
            {
                case 0:
                    //Use Percentages and adjust both values
                    //Change both Split1 and Split2
                    Split1 = (splitPercentage *Total) ;
                    Split2 = Total - Split1; //The Rest..
                    tbSplit1.Text = ((float)Split1).ToString("c");
                    tbSplit2.Text = ((float)Split2).ToString("c");
                    break;
                case 1:
                    //Change Split 2
                    Split2 = Total - Split1;
                    splitPercentage = (Split1 / Total);
                    tbSplit2.Text = ((float)Split2).ToString("c");
                    break;
                case 2:
                    Split1 = Total - Split2;
                    splitPercentage = (Split1 / Total);
                    tbSplit1.Text = ((float)Split1).ToString("c");
                    //Change Split 1
                    break;
            }
        }
        private void tbSplit1_Leave(object sender, EventArgs e)
        {
            Split1 = float.Parse(tbSplit1.Text, NumberStyles.Currency, null);
            tbSplit1.Text = ((float)Split1).ToString("c");
            CalculateSplit(1);
        }
        private void tbSplit2_Leave(object sender, EventArgs e)
        {
            Split2 = float.Parse(tbSplit2.Text, NumberStyles.Currency, null);
            tbSplit2.Text = ((float)Split2).ToString("c");
            CalculateSplit(2);
        }
        private void tbTotal_Leave(object sender, EventArgs e)
        {
            Total = float.Parse(tbTotal.Text, NumberStyles.Currency, null);
            tbTotal.Text = ((float)Total).ToString("c");
            CalculateSplit(0);
        }
    }
}
