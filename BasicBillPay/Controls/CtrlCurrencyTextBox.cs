using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Models;
using BasicBillPay.Tools;
using System.Globalization;

namespace BasicBillPay.Controls
{
    /// <summary>
    /// Will be used at Design Time so no custom Constructor
    /// </summary>
    public partial class CtrlCurrencyTextBox : UserControl
    {
        INotifyPropertyChanged dataObject;
        String propertyName;
        bool isValid = true;
        String badFloat = String.Empty;
        public event EventHandler<AmountChangedEventArgs> ValueChanged;
        public CtrlCurrencyTextBox()
        {
            InitializeComponent();
        }

        private float value = 0f;
        public float Value
        {
            get { return value; }
            set
            {
                if (value != this.value)
                {
                    this.value = value;
                    ValueChanged?.Invoke(this, new AmountChangedEventArgs(this.value));
                }
            }
        }

        public void Bind(INotifyPropertyChanged dataObject, String propertyName)
        {
            this.dataObject = dataObject;
            this.propertyName = propertyName;
            Bind();
        }
        /// <summary>
        /// One Way binding..
        /// </summary>
        /// <param name="dataSource"></param>
        public void Bind(object dataSource)
        {
            tbCurrency.DataBindings.Clear();
            Binding b = new Binding("Text", dataSource, "");

            b.Format += B_Format;
            b.Parse += B_Parse;
            //// Add the delegates to the event.

            b.Format -= new ConvertEventHandler(Conversion.FloatToCurrencyString);//Remove First Pattern
            b.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
            b.Parse -= new ConvertEventHandler(Conversion.CurrencyStringToFloat);//Remove First Pattern
            b.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
            tbCurrency.DataBindings.Add(b);

        }
        private void Bind()
        {
            if (dataObject != null && !String.IsNullOrEmpty(propertyName))
            {

                dataObject.PropertyChanged -= DataObject_PropertyChanged; //Remove First Pattern
                dataObject.PropertyChanged += DataObject_PropertyChanged;
                tbCurrency.DataBindings.Clear();
                Binding b = new Binding("Text", dataObject, propertyName);

                b.Format += B_Format;
                b.Parse += B_Parse;
                //// Add the delegates to the event.

                b.Format -= new ConvertEventHandler(Conversion.FloatToCurrencyString);//Remove First Pattern
                b.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
                b.Parse -= new ConvertEventHandler(Conversion.CurrencyStringToFloat);//Remove First Pattern
                b.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
                tbCurrency.DataBindings.Add(b);
            }

        }

        private void B_Parse(object sender, ConvertEventArgs e)
        {
           
        }

        private void B_Format(object sender, ConvertEventArgs e)
        {
            if(!isValid)
                e.Value = badFloat;
        }

        private void DataObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Bind(); //Updates the Value if it was changed elsewhere.
           // throw new NotImplementedException();
        }

        private void tbCurrency_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbCurrency.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                this.Validate();
            }
        }

        private void tbCurrency_Leave(object sender, EventArgs e)
        {
           // Value = float.Parse(tbCurrency.Text, NumberStyles.Currency, null);
           // tbCurrency.Text = (Value).ToString("c");
        }

        private void CtrlCurrencyTextBox_BackColorChanged(object sender, EventArgs e)
        {
            tbCurrency.BackColor = BackColor;
        }



        private void tbCurrency_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Value = float.Parse(tbCurrency.Text, NumberStyles.Currency, null);
                tbCurrency.Text = (Value).ToString("c");
                isValid = true;
                badFloat = String.Empty;
            }
            catch(Exception err)
            {
                badFloat = tbCurrency.Text;
                isValid = false;
                e.Cancel = true;
                tbCurrency.Select(0, tbCurrency.Text.Length);
                errorProvider1.SetError(this, "Invalid Currency Value");
            }

        }
        private void tbCurrency_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            isValid = true;
            badFloat = String.Empty;
        }



        private void tbCurrency_Click(object sender, EventArgs e)
        {
            if (tbCurrency.Text.Contains("$"))
            {
                tbCurrency.Text = tbCurrency.Text.Replace("$", "").Replace(",","");
                tbCurrency.SelectAll();
            }
        }

        private void tbCurrency_Enter(object sender, EventArgs e)
        {
            tbCurrency.SelectAll();
        }
        /// <summary>
        /// This is for when it's not bound and it's being set.. (I think setting the value would be better.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCurrency_TextChanged(object sender, EventArgs e)
        {
            Value = float.Parse(tbCurrency.Text, NumberStyles.Currency, null);
        }
        public class AmountChangedEventArgs : EventArgs
        {
            public String ValueString { get; }
            public float Value { get; }
            public AmountChangedEventArgs(float value)
            {
                Value = value;
                ValueString = Value.ToString("C");
            }
        }
    }
}
