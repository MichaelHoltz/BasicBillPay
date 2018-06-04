using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Controls;
using BasicBillPay.Models;
using BasicBillPay.Tools;
using System.Security;
using System.Security.Cryptography;

namespace BasicBillPay
{
    public partial class frmMain : Form
    {
        Database db = null; 
        ApplicationSettings appSettings = null;
        int paymentItemIndex = 0;
        int budgetItemIndex = 0;
        public frmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            appSettings = PersistenceBase.Load<ApplicationSettings>(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.json"));
            //appSettings.Password = "This is a test Password69";
            //Get Password for settings and data
            //frmPopup fp = new frmPopup("System Password", new CtrlPassword(), this);
            //fp.ShowDialog();
            MessageBox.Show(appSettings.Password);

            // ctrlDateTimePicker1.BackColor = Color.Red;
            //ctrlDateTimePicker1.Invalidate();
            PersistenceBase.Save(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.json"), appSettings);
            LoadData();

        }

        /// <summary>
        /// Function to LoadData
        /// </summary>
        private void LoadData()
        {
            //Add Bill Header
            CtrlHeader ch = new CtrlHeader();
            flpBills.Controls.Add(ch);

            //Add Budget Header
            CtrlHeader chBudget = new CtrlHeader();
            flpBudget.Controls.Add(chBudget);

            //Load the Database
            db = PersistenceBase.Load<Database>(PersistenceBase.GetAbsolutePath(@"\Data\mybills.json"));
            //Need to Load all Controls
            foreach (Payment pItem in db.Payments)
            {
                AddPaymentCtrl(pItem);
            }
            foreach (BudgetItem bItem in db.BudgetItems)
            {
                AddBudgetCtrl(bItem);
            }
            CalculateTotals();

        }
        private void CalculateTotals()
        {
            //float Total = 0f;
            //float Total2 = 0f;
            float BudgetTotal = 0f;
            //foreach (Payment pItem in db.Payments)
            //{
            //    if (pItem.PayFromId == 0)
            //        Total += pItem.PaymentAmount; // Todo-add and account for normalized Payment Frequency
            //    if (pItem.PayFromId == 1)
            //        Total2 += pItem.PaymentAmount; // Todo-add and account for normalized Payment Frequency
            //}
            foreach (BudgetItem bItem in db.BudgetItems)
            {

                BudgetTotal += bItem.Amount; // Todo-add and account for normalized Payment Frequency
            }
            tbTotal.Text = db.GetAccountTotal("M Checking", TransactionPeriod.Monthly).ToString("c");
            tbTotal2.Text = db.GetAccountTotal("C Checking", TransactionPeriod.Monthly).ToString("c");
            tbBudgetTotal.Text = BudgetTotal.ToString("c");

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
        private void CtrlBudget_ItemDeleted(object sender, EventArgs e)
        {
            if (sender is CtrlSortableBase)
            {
                CtrlSortableBase csb = (sender as CtrlSortableBase);
                int i = 0;
                foreach (Control c in flpBudget.Controls)
                {
                    if (c is CtrlSortableBase && csb != c)
                    {
                        (c as CtrlSortableBase).UpdateIndex(i++);
                    }
                }
                budgetItemIndex = i;
            }
        }
        /// <summary>
        /// Adds a visual Control Linked to the provided Payment
        /// </summary>
        /// <param name="p"></param>
        private void AddPaymentCtrl(Payment p)
        {
            CtrlPayment ctrlPayment = new CtrlPayment(ref db, p, paymentItemIndex++);
            ctrlPayment.ItemDeleted += CtrlPayment_ItemDeleted;
            ctrlPayment.AccountSelected += CtrlPayment_AccountSelected;
            ctrlPayment.AmountChanged += CtrlPayment_AmountChanged;
            flpBills.Controls.Add(ctrlPayment);

        }

        private void CtrlPayment_AmountChanged(object sender, CtrlPayment.AmountChangedEventArgs e)
        {
            CalculateTotals();
        }

        private void CtrlPayment_AccountSelected(object sender, CtrlPayment.AccountSelectedEventArgs e)
        {
            //BudgetItem b = 
            CtrlAccount ca = new CtrlAccount(e.SelectedAccount);
            frmPopup fp = new frmPopup("Account", ca, sender as Control);
            fp.ShowDialog();
        }



        /// <summary>
        /// Adds a visual Control Linked to the provided Budget Item
        /// </summary>
        /// <param name="b"></param>
        private void AddBudgetCtrl(BudgetItem b)
        {
            CtrlBudget ctrlBudget = new CtrlBudget(b, budgetItemIndex++);
            ctrlBudget.ItemDeleted += CtrlBudget_ItemDeleted;
            flpBudget.Controls.Add(ctrlBudget);
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            ////Add Payment
            //Payment p = db.AddPayment(-1, -1, DateTime.Parse("6/15/18"), DateTime.Parse("4/30/2018"), 0.00f);
            Payment p = db.AddPayment(-1, -1, DateTime.Now, DateTime.Now.AddMonths(-1), 0.00f, TransactionPeriod.Monthly);
            //End Tryout
            AddPaymentCtrl(p);
        }
        private void btnAddBudget_Click(object sender, EventArgs e)
        {
            BudgetItem b = db.AddBudgetItem("", 0.0f, TransactionPeriod.Monthly);
            AddBudgetCtrl(b);
        }
        private void CtrlPayment_ItemDeleted(object sender, EventArgs e)
        {
            if (sender is CtrlSortableBase)
            {
                CtrlSortableBase csb = (sender as CtrlSortableBase);
                int i = 0;
                foreach (Control c in flpBills.Controls)
                {
                    if (c is CtrlSortableBase && csb != c)
                    {
                        (c as CtrlSortableBase).UpdateIndex(i++);
                    }
                }
                paymentItemIndex = i;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {
            PersistenceBase.Save(PersistenceBase.GetAbsolutePath(@"\Data\mybills.json"), db);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string password = "This is a password";
            //SecureString test = "dd";
            SecureString password = Tools.Encryption.AESGCM.Password;
            string insecurePayload = "Non-secure payload";
            byte[] insecurePayloadBytes = Encoding.ASCII.GetBytes(insecurePayload);
            int insecurePayloadByteCount = insecurePayload.Length;
            ////string cipher = Tools.Encryption.AESGCM.SimpleEncryptWithPassword("This is a test", password, insecurePayloadBytes);
            //string cipher = Tools.Encryption.AESGCM.SimpleEncryptWithPassword("This is a test", password);
            //MessageBox.Show(cipher);
            ////string plainText = Tools.Encryption.AESGCM.SimpleDecryptWithPassword(cipher, password, insecurePayloadByteCount);
            //string plainText = Tools.Encryption.AESGCM.SimpleDecryptWithPassword(cipher, password);
            //MessageBox.Show(plainText);


            ///Example of "https://stackoverflow.com/questions/12657792/how-to-securely-save-username-password-local?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa"
            // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
            byte[] plaintext = Encoding.UTF8.GetBytes("Test secure String");

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }
            byte[] ciphertext = ProtectedData.Protect(plaintext, entropy,  DataProtectionScope.CurrentUser);
            String ct = Encoding.UTF8.GetString(ciphertext);
            byte[] plaintext2 = ProtectedData.Unprotect(ciphertext, entropy, DataProtectionScope.CurrentUser);
            String pt = Encoding.UTF8.GetString(plaintext2);
        }
    }
}
