using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicBillPay
{
    public partial class frmPopup : Form
    {
        public frmPopup()
        {
            InitializeComponent();
        }
        public frmPopup(String title,  UserControl uc, Control caller)
        {
            InitializeComponent();
            Text = title;
            pnlContent.Controls.Add(uc);
            positionForm(caller);
            
        }
        private void positionForm(Control caller)
        {
            //this.Top = caller.Top;
            //this.Left = caller.Left;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
