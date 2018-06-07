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
    public partial class CtrlPayment : CtrlSortableBase
    {

        Payment p;
        Database databaseFunctions;
        public event EventHandler<AccountSelectedEventArgs> AccountSelected;
        public event EventHandler<AmountChangedEventArgs> AmountChanged;
        public CtrlPayment()
        {
            InitializeComponent();

        }
        public CtrlPayment(ref Database db, ref Payment payment, int itemIndex) : base(itemIndex)
        {
            InitializeComponent();
            //Bind to Source List FIRST
            cbPaidFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));

            databaseFunctions = db;
            //Initialize Backing Data Model
            p = payment;

            tbName.BackColor = BackColor;
            tbPayFrom.BackColor = BackColor;
            tbAmount.BackColor = BackColor;
            base.ReorderIndexes -= CtrlPayment_ReorderIndexes;
            base.ReorderIndexes += CtrlPayment_ReorderIndexes;
            //base.IndexChanged -= CtrlPayment_IndexChanged;
            //base.IndexChanged += CtrlPayment_IndexChanged;

        }
        public Payment GetPayment()
        {
            return p;
        }
        private void CtrlPayment_ReorderIndexes(object sender, EventArgs e)
        {
            p.Index = ItemIndex;
        }

        private void CtrlPayment_IndexChanged(object sender, EventArgs e)
        {
           // p.Index = ItemIndex;
           // throw new NotImplementedException();
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
            
            //Couldn't get Binding to work right so doing it manually
            cbPaidFrequency.Text = p.PayPeriod.ToString();

            tbAmount.DataBindings.Clear();
            Binding b = new Binding("Text", p, "PaymentAmount");
            // Add the delegates to the event.
            
            b.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
            b.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
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

        private void tbName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AccountSelected?.Invoke(sender, new AccountSelectedEventArgs(databaseFunctions.GetAccount(p.PayToId))); // Only fire if there is a listener
            //If they change the account name I need to update it though!!!
        }

        private void tbPayFrom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AccountSelected?.Invoke(sender, new AccountSelectedEventArgs(databaseFunctions.GetAccount(p.PayFromId))); // Only fire if there is a listener
            //If they change the account name I need to update it though!!! 
        }
        public class AccountSelectedEventArgs : EventArgs
        {
            public Account SelectedAccount { get; }
            public AccountSelectedEventArgs(Account selectedAccount)
            {
                SelectedAccount = selectedAccount;
            }
        }

        public class AmountChangedEventArgs : EventArgs
        {
            public TransactionPeriod PayPeriod { get;}
            public float Amount { get; }
            public AmountChangedEventArgs(TransactionPeriod payPeriod, float amount)
            {
                PayPeriod = payPeriod;
                Amount = amount;
            }
        }
        private void cbPaidFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaidFrequency.SelectedIndex > -1 && p != null)
            {
                p.PayPeriod = (TransactionPeriod)Enum.Parse(typeof(TransactionPeriod), cbPaidFrequency.Text);
                cbPaidFrequency.Text = p.PayPeriod.ToString();
                AmountChanged?.Invoke(sender, new AmountChangedEventArgs(p.PayPeriod, p.PaymentAmount)); // Only fire if there is a listener
            }
        }

        private void tbAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbAmount.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                p.PaymentAmount = float.Parse(tbAmount.Text, NumberStyles.Currency, null);
                tbAmount.Text = (p.PaymentAmount).ToString("c");
                AmountChanged?.Invoke(sender, new AmountChangedEventArgs(p.PayPeriod, p.PaymentAmount)); // Only fire if there is a listener
            }
        }

        private void tbAmount_Leave(object sender, EventArgs e)
        {
            p.PaymentAmount = float.Parse(tbAmount.Text, NumberStyles.Currency, null);
            AmountChanged?.Invoke(sender, new AmountChangedEventArgs(p.PayPeriod, p.PaymentAmount)); // Only fire if there is a listener
        }

        /// <summary>
        /// Update the Dates and order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPay_Click(object sender, EventArgs e)
        {
            //Need to adjust DateDue by Pay Frequency and  Paid Date to now.
            p.DatePaid = DateTime.Now;
            //Adjusting the DateDue is not going to be simple
            switch (p.PayPeriod)
            {
                case TransactionPeriod.Hourly:
                    p.DateDue = p.DateDue.AddHours(1); // This is Very unlikely to work in any way useful
                    break;
                case TransactionPeriod.Daily:
                    p.DateDue = p.DateDue.AddDays(1); //unlikely scenario
                    break;
                case TransactionPeriod.Weekly:
                    p.DateDue = p.DateDue.AddDays(7);
                    break;
                case TransactionPeriod.Biweekly:
                    p.DateDue = p.DateDue.AddDays(14);
                    break;
                case TransactionPeriod.Monthly:
                    p.DateDue =  p.DateDue.AddMonths(1);
                    break;
                case TransactionPeriod.Yearly:
                    p.DateDue = p.DateDue.AddYears(1);
                    break;
                default:
                    break;
            }

            
        
        }
    }
}
