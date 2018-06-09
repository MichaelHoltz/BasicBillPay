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
    //Account Text Box to allow linking to Account by Name
    public partial class CtrlAccountTextBox : UserControl
    {
        /// <summary>
        /// Account Selected (Selected Account available)
        /// </summary>
        public event EventHandler<AccountSelectedEventArgs> AccountSelected;
        Account a;
        public CtrlAccountTextBox()
        {
            InitializeComponent();
        }
        public CtrlAccountTextBox(Account account)
        {
            InitializeComponent();
            SetAccount(account);
        }

        private void CtrlAccountTextBox_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            //Bind only if account is not null. (Only works if dynamically loaded.
            if (a != null)
            {
                tbAccountName.DataBindings.Clear();
                tbAccountName.DataBindings.Add("Text", a.Name, "");
            }

        }
        public void SetAccount(Account account)
        {
            a = account;
            a.PropertyChanged += Account_PropertyChanged;
            Bind();
        }

        private void Account_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Bind();
        }

        private void btnAccountLink_Click(object sender, EventArgs e)
        {
            //BudgetItem b = 
            UserControl ca = new CtrlAccount(a);
            frmPopup fp = new frmPopup("Account", ref ca, sender as Control);
            fp.ShowDialog();
            tbAccountName.Text = a.Name;
            AccountSelected?.Invoke(sender, new AccountSelectedEventArgs(a)); // Only fire if there is a listener
        }
        public class AccountSelectedEventArgs : EventArgs
        {
            public Account SelectedAccount { get; }
            public AccountSelectedEventArgs(Account selectedAccount)
            {
                SelectedAccount = selectedAccount;
            }
        }

        private void tbAccountName_KeyUp(object sender, KeyEventArgs e)
        {
            a.Name = tbAccountName.Text;
        }

        private void CtrlAccountTextBox_BackColorChanged(object sender, EventArgs e)
        {
            tbAccountName.BackColor = this.BackColor;
            btnAccountLink.BackColor = BackColor;
        }
    }
}
