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
using BasicBillPay.Tools;
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
    }
}
