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

namespace BasicBillPay.Controls
{
    /// <summary>
    /// Payment Confirmation
    /// </summary>
    public partial class CtrlPaymentConfirm : UserControl
    {
        Payment p;
        public CtrlPaymentConfirm()
        {
            InitializeComponent();
        }
        public CtrlPaymentConfirm(Payment payment)
        {
            InitializeComponent();
            p = payment;

        }

        private void CtrlPaymentConfirm_Load(object sender, EventArgs e)
        {
            if (p.Reference == null)
                p.Reference = String.Empty; 
            tbAuthorization.DataBindings.Clear();
            tbAuthorization.DataBindings.Add("Text", p.Reference, "");

            tbAmount.DataBindings.Clear();
            tbAmount.DataBindings.Add("Text", p.PaymentAmount, "");
            ctrlCurrencyTextBox1.Bind(p, "PaymentAmount");
            
        }

        private void tbAuthorization_KeyUp(object sender, KeyEventArgs e)
        {
            p.Reference = tbAuthorization.Text;
        }

        private void tbAmount_KeyUp(object sender, KeyEventArgs e)
        {
            p.PaymentAmount = float.Parse(tbAmount.Text);
        }

        private void ctrlCurrencyTextBox1_ValidationFailed(object sender, EventArgs e)
        {
            epGeneral.SetError(ctrlCurrencyTextBox1, "Invalid Currency Value");
        }

        private void ctrlCurrencyTextBox1_ValidationSucceeded(object sender, EventArgs e)
        {
            epGeneral.Clear();
        }
    }
}
