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
    public partial class CtrlPaymentItem : CtrlSortableBase
    {

        Payment p;
        Database databaseFunctions;
        ///// <summary>
        ///// Account Selected (Selected Account available)
        ///// </summary>
        //public event EventHandler<AccountSelectedEventArgs> AccountSelected;
        /// <summary>
        /// Payment Amount Changed (Transaction Period and Amount available)
        /// </summary>
        public event EventHandler<AmountChangedEventArgs> AmountChanged;
        /// <summary>
        /// General Payment Changed Event (Name change is the most common use.)
        /// </summary>
        public event EventHandler<PaymentChangedEventArgs> PaymentChanged;
        public CtrlPaymentItem()
        {
            InitializeComponent();

        }
        public CtrlPaymentItem(ref Database db, ref Payment payment, int itemIndex) : base(itemIndex)
        {
            InitializeComponent();

            //Bind to Source List FIRST
            cbPaidFrequency.DataSource = Enum.GetNames(typeof(TransactionPeriod));

            databaseFunctions = db;
            //Initialize Backing Data Model
            p = payment;

            catbPayTo.BackColor = BackColor;
            catbPayFrom.BackColor = BackColor;
            cctbAmount.BackColor = BackColor;
            base.ReorderIndexes -= CtrlPayment_ReorderIndexes;
            base.ReorderIndexes += CtrlPayment_ReorderIndexes;
            //base.IndexChanged -= CtrlPayment_IndexChanged;
            //base.IndexChanged += CtrlPayment_IndexChanged;

        }
        public List<HeaderItem> GetHeaderItems()
        {
            List<HeaderItem> retVal = new List<HeaderItem>();
            //Want to order by Tab Index
            foreach (Control item in Controls.OfType<Control>().OrderBy(o=>o.TabIndex))
            {
                if (item.Tag.ToString() != "Ignore")
                {
                    HeaderItem hi = new HeaderItem();
                    hi.Title = item.Tag.ToString(); // 
                    hi.Width = item.Width;
                    hi.SourceLeft = item.Left;

                    retVal.Add(hi);
                }
            }
            return retVal;
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
        }

        private void CtrlPayment_Load(object sender, EventArgs e)
        {
            //Set DataBindings 
            if (p.PayToId != -1)
            {
                //Need to track Name Changes for Pay To Account since it is used as the label for the Chart
                catbPayTo.SetAccount(databaseFunctions.GetAccount(p.PayToId)); //Sets Text Value
            }

            if (p.PayFromId != -1)
            { 
                catbPayFrom.SetAccount(databaseFunctions.GetAccount(p.PayFromId)); //Sets Text Value
            }

            dtpDateDue.DataBindings.Clear();
            dtpDateDue.DataBindings.Add("Text", p, "DateDue");

            dtpDatePaid.DataBindings.Clear();
            dtpDatePaid.DataBindings.Add("Text", p, "DatePaid");
            
            //Couldn't get Binding to work right so doing it manually
            cbPaidFrequency.Text = p.PayPeriod.ToString();

            cctbAmount.Bind(p, "PaymentAmount");
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

        /// <summary>
        /// Update the Dates and order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPay_Click(object sender, EventArgs e)
        {
            //Need to adjust DateDue by Pay Frequency and  Paid Date to now.
            p.DatePaid = DateTime.Now;
            dtpDatePaid.Value = p.DatePaid; // Manual Bind
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
            dtpDateDue.Value = p.DateDue; // Manual Bind

            //If there is a valid Link bring it up.
            Account a = databaseFunctions.GetAccount(p.PayToId);
            if (a.Link != null)
            {
                String url = a.Link;
                //For safety this should be validated to be a web page - Since the user is in full control and it's encrypted it should be ok
                //If this were not a page, but some system command that would be bad.
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)  && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                if (result)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(uriResult.AbsoluteUri); // This would be a potential problem for publishing this app..
                        
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error with Account link for Account: '" + a.Name + "' using Link: '" + a.Link + "'\r\n" + err.Message, "Link Exception");
                    }
                }

            }
            CtrlPaymentConfirm cpc = new CtrlPaymentConfirm(p);
            Forms.ShowPopupControl(cpc, "Payment Confirmation Information", btnPay);
            //MessageBox.Show("Now need the Confirmation Number");

        }

        private void cctbAmount_ValueChanged(object sender, CtrlCurrencyTextBox.AmountChangedEventArgs e)
        {
            p.PaymentAmount = e.Value; // Value does not need to be translated because it is set in the control.
            AmountChanged?.Invoke(sender, new AmountChangedEventArgs(p.PayPeriod, p.PaymentAmount));
        }

        private void catbPayTo_AccountChanged(object sender, AccountChangedEventArgs e)
        {
            PaymentChanged?.Invoke(sender, new PaymentChangedEventArgs(e.OldName, e.SelectedAccount.Name, p));
        }

        private void catbPayFrom_AccountChanged(object sender, AccountChangedEventArgs e)
        {
            //Pay From isn't tracked the same way so not going to raise the event at this time.
            //PaymentChanged?.Invoke(sender, new PaymentChangedEventArgs(e.OldName, e.SelectedAccount.Name, p));
        }
    }
    public class AmountChangedEventArgs : EventArgs
    {
        public TransactionPeriod PayPeriod { get; }
        public float Amount { get; }
        public AmountChangedEventArgs(TransactionPeriod payPeriod, float amount)
        {
            PayPeriod = payPeriod;
            Amount = amount;
        }
    }
    public class PaymentChangedEventArgs : EventArgs
    {
        public String OldName { get; }
        public String NewName { get; }
        public Payment Payment { get; }
        public PaymentChangedEventArgs(String oldName, String newName, Payment payment)
        {
            OldName = oldName;
            NewName = newName;
            Payment = payment;
        }
    }
}
