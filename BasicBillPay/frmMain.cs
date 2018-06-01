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
namespace BasicBillPay
{
    public partial class frmMain : Form
    {
        Database db = null; // new Database();
        int ItemIndex = 0;
        public frmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Add Bill Header
            CtrlHeader ch = new CtrlHeader();
            flpBills.Controls.Add(ch);
            //Load the Database
            db = PersistenceBase.Load<Database>(PersistenceBase.GetAbsolutePath(@"\Data\mybills.json"));

            //Need to Load all Controls
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            //Tryout only
            //Add Payment Account
            Account pTo = db.AddAccount("Water / Sewer / Trash", "123", "https://www.oxnard.org/online-payments/", "wst.oxnard");
            //Add Source Account
            Account pFrom = db.AddAccount("M Checking", "123", "www.encryptme.com", "mUserName");

            //Add Payment
            Payment p = db.AddPayment(pTo.Id, pFrom.Id, DateTime.Parse("6/15/18"), DateTime.Parse("4/30/2018"), 225.00f, ref db);

            //End Tryout
            CtrlPayment cp = new CtrlPayment(p, ItemIndex++);
            cp.ItemDeleted += Cp_ItemDeleted;
            flpBills.Controls.Add(cp);
        }

        private void Cp_ItemDeleted(object sender, EventArgs e)
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
                ItemIndex = i;
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
            frmSplitItemTest fsit = new frmSplitItemTest();
            fsit.ShowDialog();
        }
    }
}
