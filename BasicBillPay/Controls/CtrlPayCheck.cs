using System;
using System.Windows.Forms;
using BasicBillPay.Models;
using BasicBillPay.Tools;
using System.Globalization;

namespace BasicBillPay.Controls
{
    public partial class CtrlPaycheck : UserControl
    {
        Paycheck pc = null;
        TransactionPeriod currentTransactionPeriod = TransactionPeriod.Monthly; // Default Period
        public CtrlPaycheck()
        {
            InitializeComponent();
        }
        public CtrlPaycheck(Paycheck paycheck)
        {
            InitializeComponent();
            //Bind to Source List FIRST
            cbPaidFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));
            pc = paycheck;

            
           
        }

        private void ControlPaycheck_Load(object sender, EventArgs e)
        {
            Charts.InitializeChart(chartPayCheck, "PayCheck");

            tbName.DataBindings.Clear();
            tbName.DataBindings.Add("Text", pc, "Name");

            cctbNetPay.Bind(pc, "NetPayPerPayPeriod");
            BindControl(tbNetPay, "Text", "NetPayPerPayPeriod");
            Charts.AddChartPoint(chartPayCheck, "Net Pay", pc.NetPayPerPayPeriod);


            //tbNetPay.DataBindings.Clear();
            //Binding b = new Binding("Text", pc, "NetPayPerPayPeriod");
            //// Add the delegates to the event.
            //b.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
            //b.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
            //tbNetPay.DataBindings.Add(b);

            cbPaidFrequency.Text = pc.PayPeriod.ToString();

            dtpPayDayStart.DataBindings.Clear();
            dtpPayDayStart.DataBindings.Add("Text", pc, "PayDayStart");

            
            BindControl(tbGrossPay, "Text", "GrossPayPerPayPeriod");
            //No Chart because this is the total

            BindControl(tbTax, "Text", "TaxPerPayPeriod");
            Charts.AddChartPoint(chartPayCheck, "Tax", pc.TaxPerPayPeriod);

            BindControl(tbBenefitCost, "Text", "BenefitCostPerPayPeriod");
            Charts.AddChartPoint(chartPayCheck, "Benefit Cost", pc.BenefitCostPerPayPeriod);

            BindControl(tbGarnishment, "Text", "GarnishmentCostPerPayPeriod");
            Charts.AddChartPoint(chartPayCheck, "Garnishment", pc.GarnishmentCostPerPayPeriod);

            BindControl(tbOther, "Text", "OtherCostPerPayPeriod");
            Charts.AddChartPoint(chartPayCheck, "Other", pc.OtherCostPerPayPeriod);

            lblIdValue.Text = pc.Id.ToString("00");
        }

        private void BindControl(Control c, String ctrlProp, String objProp )
        {
            c.DataBindings.Clear();
            Binding b = new Binding(ctrlProp, pc, objProp);
            // Add the delegates to the event.
            b.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
            b.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
            c.DataBindings.Add(b);
        }
        private void cbPaidFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaidFrequency.SelectedIndex >= 0 && pc!= null)
            {
                pc.PayPeriod = (TransactionPeriod)Enum.Parse(typeof(TransactionPeriod), cbPaidFrequency.SelectedItem.ToString());
            }
        }

        private void tbNetPay_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbNetPay.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                UpdateNetPay();
            }
        }
        private void tbNetPay_Leave(object sender, EventArgs e)
        {
            UpdateNetPay();
        }
        private void UpdateNetPay()
        {
            pc.NetPayPerPayPeriod = float.Parse(tbNetPay.Text, NumberStyles.Currency, null);
            tbNetPay.Text = (pc.NetPayPerPayPeriod).ToString("c");
            Charts.AddChartPoint(chartPayCheck, "Net Pay", pc.NetPayPerPayPeriod);
        }
        private void tbGrossPay_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbGrossPay.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                UpdateGrossPay();
            }
        }
        private void tbGrossPay_Leave(object sender, EventArgs e)
        {
            UpdateGrossPay();
        }
        private void UpdateGrossPay()
        {
            pc.GrossPayPerPayPeriod = float.Parse(tbGrossPay.Text, NumberStyles.Currency, null);
            tbGrossPay.Text = (pc.GrossPayPerPayPeriod).ToString("c");
        }
        private void tbTax_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbTax.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                UpdateTax();
            }
        }
        private void tbTax_Leave(object sender, EventArgs e)
        {
            UpdateTax();
        }
        private void UpdateTax()
        {
            pc.TaxPerPayPeriod = float.Parse(tbTax.Text, NumberStyles.Currency, null);
            tbTax.Text = (pc.TaxPerPayPeriod).ToString("c");
            Charts.AddChartPoint(chartPayCheck, "Tax", pc.TaxPerPayPeriod);
        }
        private void tbBenefitCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbBenefitCost.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                UpdateBenefitCost();
            }
        }
        private void tbBenefitCost_Leave(object sender, EventArgs e)
        {
            UpdateBenefitCost();
        }
        private void UpdateBenefitCost()
        {
            pc.BenefitCostPerPayPeriod = float.Parse(tbBenefitCost.Text, NumberStyles.Currency, null);
            tbBenefitCost.Text = (pc.BenefitCostPerPayPeriod).ToString("c");
            Charts.AddChartPoint(chartPayCheck, "Benefit Cost", pc.BenefitCostPerPayPeriod);
        }
        private void tbGarnishment_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbGarnishment.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                UpdateGarnishment();
            }
        }
        private void tbGarnishment_Leave(object sender, EventArgs e)
        {
            UpdateGarnishment();
        }
        private void UpdateGarnishment()
        {
            pc.GarnishmentCostPerPayPeriod = float.Parse(tbGarnishment.Text, NumberStyles.Currency, null);
            tbGarnishment.Text = (pc.GarnishmentCostPerPayPeriod).ToString("c");
            Charts.AddChartPoint(chartPayCheck, "Garnishment", pc.GarnishmentCostPerPayPeriod);
        }
        private void tbOther_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbOther.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                UpdateOther();
            }
        }

        private void tbOther_Leave(object sender, EventArgs e)
        {
            UpdateOther();
        }
        private void UpdateOther()
        {
            pc.OtherCostPerPayPeriod = float.Parse(tbOther.Text, NumberStyles.Currency, null);
            tbOther.Text = (pc.OtherCostPerPayPeriod).ToString("c");
            Charts.AddChartPoint(chartPayCheck, "Other", pc.OtherCostPerPayPeriod);
        }

        private void CtrlPaycheck_Leave(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
