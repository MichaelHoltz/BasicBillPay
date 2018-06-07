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
using System.Globalization;

namespace BasicBillPay.Controls
{
    public partial class CtrlAccount : UserControl
    {
        Account a;
        float balance;
        public CtrlAccount()
        {
            InitializeComponent();
        }
        public CtrlAccount(Account account)
        {
            InitializeComponent();
            cbAccountType.DataSource = Enum.GetNames(typeof(AccountType));
            a = account;

               
        }

        private void CtrlAccount_Load(object sender, EventArgs e)
        {
            tbName.DataBindings.Clear();
            tbName.DataBindings.Add("Text", a, "Name");

            tbBalance.DataBindings.Clear();
            Binding b = new Binding("Text", a, "Balance");
            // Add the delegates to the event.
            b.Format += new ConvertEventHandler(Conversion.FloatToCurrencyString);
            b.Parse += new ConvertEventHandler(Conversion.CurrencyStringToFloat);
            tbBalance.DataBindings.Add(b);

            cbAccountType.Text = a.Type.ToString();

            tbNumber.DataBindings.Clear();
            tbNumber.DataBindings.Add("Text", a, "Number");

            tbLink.DataBindings.Clear();
            tbLink.DataBindings.Add("Text", a, "Link");

            tbUserName.DataBindings.Clear();
            tbUserName.DataBindings.Add("Text", a, "UserName");

            lblIdValue.Text = a.Id.ToString("00");
        }

        private void tbBalance_Leave(object sender, EventArgs e)
        {

            balance = float.Parse(tbBalance.Text, NumberStyles.Currency, null);
            tbBalance.Text = ((float)balance).ToString("c");
        }


        private void tbBalance_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                balance = float.Parse(tbBalance.Text, NumberStyles.Currency, null);
                tbBalance.Text = ((float)balance).ToString("c");
            }
        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountType.SelectedIndex >= 0 && a!= null)
            {
                a.Type = (AccountType)Enum.Parse(typeof(AccountType), cbAccountType.SelectedItem.ToString());
            }
        }
    }
}
