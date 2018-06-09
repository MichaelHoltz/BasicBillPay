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
            
        }
    }
}
