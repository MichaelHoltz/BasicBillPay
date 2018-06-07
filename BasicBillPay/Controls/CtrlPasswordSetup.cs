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
    public partial class CtrlPasswordSetup : UserControl
    {
        public String Password { get; set; }
        public CtrlPasswordSetup()
        {
            InitializeComponent();
            
        }
        private void CtrlPassword_Load(object sender, EventArgs e)
        {
            Icon i = new Icon(SystemIcons.Warning, new Size(8, 8));
            epPasswordLength.Icon = i;

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
                this.epPasswordLength.SetError(tbPassword, errorMsg);
            }
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            this.epPasswordLength.SetError(tbPassword, "");
            AESGCM.Password = tbPassword.Text;
            Password = tbPassword.Text;
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
                errorMessage = "Password must be at least 4 characters long.";
            }
            return retVal;
        }



        private void tbPasswordConfirm_Validated(object sender, EventArgs e)
        {
            epMatchingPasswords.SetError(tbPasswordConfirm, ""); 
        }

        private void tbPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
