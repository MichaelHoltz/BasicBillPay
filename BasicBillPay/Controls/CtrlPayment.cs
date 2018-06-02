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
        Database databaseFunctions;
        public CtrlPayment()
        {
            InitializeComponent();

        }
        public CtrlPayment(ref Database db, Payment payment, int itemIndex) : base(itemIndex)
        {
            InitializeComponent();
            databaseFunctions = db;
            //Initialize Backing Data Model
            p = payment;
            

        }

        private void CtrlPayment_Load(object sender, EventArgs e)
        {
            //Set DataBindings 
            tbName.DataBindings.Clear();
            if (p.PayToId == -1)
            {
                //Need to add new account or link to Existing one.
            }
            else
            {
                tbName.DataBindings.Add("Text", databaseFunctions.GetAccount(p.PayToId), "Name");
            }

            tbPayFrom.DataBindings.Clear();
            if (p.PayFromId == -1)
            {
                //Need to add new account or link to Existing one.
            }
            else
            {
                tbPayFrom.DataBindings.Add("Text", databaseFunctions.GetAccount(p.PayFromId), "Name");
            }

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
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            //Only do this for Unlinked account
            if (p.PayToId == -1)
            {
                Account a = databaseFunctions.GetAccount(tbName.Text);
                if (a != null)
                {
                    if (MessageBox.Show("Account Found with that name, would you like to link to it?", "Confirm Account Link", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        p.PayToId = a.Id;
                        tbName.DataBindings.Clear();
                        tbName.DataBindings.Add("Text", a, "Name");
                    }
                }
            }
        }
        private void tbPayFrom_TextChanged(object sender, EventArgs e)
        {
            //Only do this for Unlinked account
            if (p.PayFromId == -1)
            {
                Account a = databaseFunctions.GetAccount(tbPayFrom.Text);
                if (a != null)
                {
                    if (MessageBox.Show("Account Found with that name, would you like to link to it?", "Confirm Account Link", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        p.PayFromId = a.Id;
                        tbPayFrom.DataBindings.Clear();
                        tbPayFrom.DataBindings.Add("Text", a, "Name");
                    }
                }
            }
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
