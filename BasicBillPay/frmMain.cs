using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BasicBillPay.Controls;
using BasicBillPay.Models;
using BasicBillPay.Tools;
using BasicBillPay.Tools.Encryption;
using System.Security;
using System.Security.Cryptography;
using System.Globalization;

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
            db = PersistenceBase.Load<Database>(appSettings.DbPath);
            appSettings = PersistenceBase.GetApplicationSettings(this);

        }
        internal frmMain(ApplicationSettings appSettings, Database database)
        {
            InitializeComponent();
            this.appSettings = appSettings;
            db = database;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Function to LoadData
        /// </summary>
        private void LoadData()
        {
            this.SuspendLayout();
            flpPeopleBills.SuspendLayout();

            flpPeopleBills.Controls.Clear();

            foreach (Person p in db.People)
            {
                Person rp = p;
                CtrlPerson cp = new CtrlPerson(ref db, ref paymentItemIndex, ref rp);
                flpPeopleBills.Controls.Add(cp);

            }

            //Add Budget Items
            CtrlBudget cb = new CtrlBudget(ref db, ref budgetItemIndex);
            flpPeopleBills.Controls.Add(cb);

            flpPeopleBills.ResumeLayout();
            this.ResumeLayout(true);

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {
            PersistenceBase.SaveData(appSettings, db);
        }
        private void systemPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWelcomePassword fwp = new frmWelcomePassword(appSettings, db);
            fwp.ShowDialog();
        }

        private void managePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleManager fpm = new frmPeopleManager(ref db);
            fpm.ShowDialog();
            //Need to refresh all items if Names changed or People were added.
            LoadData();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings fs = new frmSettings(appSettings);
            if (fs.ShowDialog() == DialogResult.OK)
            {
                PersistenceBase.Save(PersistenceBase.GetAbsolutePath(@"\Data\ApplicationSettings.bbp"), appSettings);
                db = PersistenceBase.Load<Database>(appSettings.DbPath);
                //Need to Check Verification before Use.
                if (db.Verification == appSettings.Verification)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Wrong password for DataFile!");
                }

            }
        }
         
    }
}
