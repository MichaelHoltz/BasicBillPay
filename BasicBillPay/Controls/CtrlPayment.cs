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

namespace BasicBillPay.Controls
{
    public partial class CtrlPayment : CtrlSortableBase
    {

        Payment p;
        public CtrlPayment()
        {
            InitializeComponent();

        }
        public CtrlPayment(Payment payment, int itemIndex) : base(itemIndex)
        {
            InitializeComponent();
            //Initialize Backing Data Model
            p = payment;
            
            //Set DataBindings 

            tbName.DataBindings.Clear();
            tbName.DataBindings.Add("Text", p.PayTo, "Name");

            dtpDateDue.DataBindings.Clear();
            dtpDateDue.DataBindings.Add("Text", p, "DateDue");

            dtpDatePaid.DataBindings.Clear();
            dtpDatePaid.DataBindings.Add("Text", p, "DatePaid");


            tbAmount.DataBindings.Clear();
            Binding b = new Binding("Text", p, "PaymentAmount");
            // Add the delegates to the event.
            b.Format += new ConvertEventHandler(floatToCurrencyString);
            b.Parse += new ConvertEventHandler(currencyStringToFloat);
            tbAmount.DataBindings.Add(b);
        }

        private void floatToCurrencyString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("c").
            cevent.Value = ((float)cevent.Value).ToString("c");
        }

        private void currencyStringToFloat(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to decimal type only. 
            if (cevent.DesiredType != typeof(float)) return;

            // Converts the string back to decimal using the static Parse method.
            cevent.Value = float.Parse(cevent.Value.ToString(), NumberStyles.Currency, null);
        }
    }
}
