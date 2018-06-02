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
    public partial class CtrlBudget : CtrlSortableBase
    {
        private float Total = 100f;
        private float Split1 = 50f;
        private float Split2 = 50f;
        private float splitPercentage = .5f;
        BudgetItem b;
        public CtrlBudget()
        {
            InitializeComponent();
        }
        public CtrlBudget(BudgetItem budgetItem, int itemIndex) : base(itemIndex)
        {
            InitializeComponent();
            b = budgetItem;
            tbName.Text = b.Name;
            Total = b.Amount;
            Split1 = b.Split1Amount;
            Split2 = b.Split2Amount;
            cbPaidFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));

        }
        private void CtrlBudget_Load(object sender, EventArgs e)
        {
            cbPaidFrequency.Text = b.PaidFrequency.ToString();
            tbAmount.Text = Total.ToString("c");
            tbSplit1Amount.Text = Split1.ToString("c");
            tbSplit2Amount.Text = Split2.ToString("c");
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
        }

        private void tbSplit2Amount_Leave(object sender, EventArgs e)
        {
            Split2 = float.Parse(tbSplit2Amount.Text, NumberStyles.Currency, null);
            tbSplit2Amount.Text = ((float)Split2).ToString("c");
            CalculateSplit(2);
        }
        private void tbAmount_Leave(object sender, EventArgs e)
        {
            Total = float.Parse(tbAmount.Text, NumberStyles.Currency, null);
            tbAmount.Text = ((float)Total).ToString("c");
            CalculateSplit(0);
        }

    }
}
