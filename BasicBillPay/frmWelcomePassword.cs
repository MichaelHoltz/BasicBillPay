using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Tools.Encryption;
using BasicBillPay.Controls;
using BasicBillPay.Models;
namespace BasicBillPay
{
    public partial class frmWelcomePassword : Form
    {
        ApplicationSettings appSettings = null;
        Database db = null;
        public frmWelcomePassword()
        {
            InitializeComponent();
        }
        internal frmWelcomePassword(ApplicationSettings appSettings, Database database)
        {
            InitializeComponent();
            cbEncryptionType.DataSource = Enum.GetNames(typeof(EncryptionLevel));
            this.appSettings = appSettings;
            db = database;
        }

        private void frmWelcomePassword_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Your data is encrypted with use of your password.\r\nPlease enter your password to continue.";
            cbEncryptionType.Text = appSettings.EncryptionLevel.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            appSettings.EncryptionLevel = (EncryptionLevel)Enum.Parse(typeof(EncryptionLevel), cbEncryptionType.Text);
            switch (appSettings.EncryptionLevel)
            {
                case EncryptionLevel.None:
                    appSettings.Password = null;
                    break;
                case EncryptionLevel.Auto:
                    appSettings.Password = CryptoPassword.GetMAC();
                    break;
                case EncryptionLevel.Full:
                    appSettings.Password = ctrlPasswordSetup1.Password;
                    break;
            }
            AESGCM.Password = appSettings.Password;
            this.Close();
        }
    }
}
