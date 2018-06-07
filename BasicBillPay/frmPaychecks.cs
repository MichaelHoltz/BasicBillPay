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
        public frmPaychecks()
        {
            InitializeComponent();
        }
        public frmPaychecks(Database database)
        {
            InitializeComponent();
            db = database;
        }

        private void frmPaychecks_Load(object sender, EventArgs e)
        {
            foreach (Paycheck pc in db.GetPayChecks())
            {
                CtrlPaycheck cpc = new CtrlPaycheck(pc);
                flpPaychecks.Controls.Add(cpc);
            }
        }
    }
}
