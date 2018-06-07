using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Tools;
using BasicBillPay.Controls;
using BasicBillPay.Models;
namespace BasicBillPay
{
    /// <summary>
    /// Main Entry to application
    /// 
    /// Specific use is for Initial Setup if the Settings Files are not found / empty.
    /// This Form only needs to be shown if ApplicationSettings are not found / incomplete
    /// </summary>
    public partial class frmWelcome : Form
    {
        ApplicationSettings appSettings = null;
        Database db = null;
        public frmWelcome()
        {
            InitializeComponent();
            appSettings = PersistenceBase.GetApplicationSettings(this);
            db = PersistenceBase.LoadDatabase(appSettings.DbPath);
            if (db.Accounts.Count > 0 && db.PayChecks.Count > 0)
            {
                //Get out already before showing the form
                
            }
        }
        public frmWelcome(ApplicationSettings appSettings, Database database)
        {
            InitializeComponent();
            this.appSettings = appSettings;
            db = database;

        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Welcome to the one time setup. Please choose your security level and Enter your name. Don't worry, all values can be changed later.";
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (rbStoreUserPassword.Checked)
            {
                appSettings.EncryptionLevel = EncryptionLevel.Full;
                appSettings.Password = ctrlPassword1.Password; 
            }
            if (rbAutoEncrypt.Checked)
            {
                appSettings.EncryptionLevel = EncryptionLevel.Auto;
            }

            Person person = db.AddPerson(tbName.Text.Trim());
            //Get Proper Ending
            String ending = "'s ";
            if (person.Name.EndsWith("s"))
            {
                ending = "' ";
            }
            //Add Default Income Tracking Account
            String accountName = person.Name + ending;
            if (rbCheckingAccount.Checked)
            {
                accountName += "Checking Account";    
            }
            else
            {
                accountName += "Cash Account";
            }
            //Add account to Database
            Account a =db.AddAccount(accountName, AccountType.Income, null, null, null);
            //Associate the Account with this person
            person.AccountIds.Add(a.Id);


            //Add Default Pay Source Account
            String payCheckName = person.Name + ending + "Paycheck";
            //Add Paycheck to database
            Paycheck pc = db.AddPayCheck(payCheckName, TransactionPeriod.Biweekly); // Need to Ask
            //Associate the paycheck with this person
            person.PaycheckIds.Add(pc.Id);
            //Forms.ShowPopupControl(new CtrlPaycheck(pc), payCheckName, btnBegin);
            this.Close(); // Move On
        }

        private void frmWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save modifications so far.
            PersistenceBase.SaveData(appSettings, db);
        }
    }
}
