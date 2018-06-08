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

namespace BasicBillPay
{
    public partial class frmPaychecks : Form
    {
        Database db = null;
        Person p;
        public frmPaychecks()
        {
            InitializeComponent();
        }
        public frmPaychecks(Database database, Person person)
        {
            InitializeComponent();
            db = database;
            p = person;
        }

        private void frmPaychecks_Load(object sender, EventArgs e)
        {

            foreach (Paycheck pc in db.GetPayChecks())
            {
                if (p.PaycheckIds.Contains(pc.Id)) // One of my Paychecks
                {
                    AddPaycheck(pc);
                }

            }
        }

        private void btnAddPayCheck_Click(object sender, EventArgs e)
        {
            Paycheck pc = db.AddPayCheck("New Paycheck", TransactionPeriod.Biweekly);
            p.PaycheckIds.Add(pc.Id); // Add the PayCheck ID.
            AddPaycheck(pc);
            
            
        }

        private void AddPaycheck(Paycheck pc)
        {
            CtrlPaycheck cpc = new CtrlPaycheck(pc);
            flpPaychecks.Controls.Add(cpc);
        }
    }
}
