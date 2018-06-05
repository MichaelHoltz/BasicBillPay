using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using BasicBillPay.Tools.Encryption;

namespace BasicBillPay.Controls
{
    public partial class CtrlPassword : UserControl
    {
        
        public CtrlPassword()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            AESGCM.Password = tbPassword.Text;
        }
        SecureString securePwd = new SecureString();

        public SecureString convertToSecureString(string strPassword)
        {
            var secureStr = new SecureString();
            if (strPassword.Length > 0)
            {
                foreach (var c in strPassword.ToCharArray()) secureStr.AppendChar(c);
            }
            return secureStr;
        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidPassword(tbPassword.Text, out errorMsg))
            {
                e.Cancel = true;
                tbPassword.Select(0, tbPassword.Text.Length);
                this.errorProvider1.SetError(tbPassword, errorMsg);
            }
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(tbPassword, "");
        }
        public bool ValidPassword(String password, out String errorMessage)
        {
            bool retVal = false;
            if (password.Length >= 4)
            {
                errorMessage = "";
                retVal = true;
            }
            else
            {
                errorMessage = "Password must be at least 12 characters long.";
            }
            return retVal;
        }
    }
}
