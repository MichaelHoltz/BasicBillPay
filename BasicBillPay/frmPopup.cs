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
        UserControl uc;
        Control callingControl;
        public frmPopup()
        {
            InitializeComponent();
        }
        public frmPopup(String title, ref UserControl userControl, Control caller)
        {
            InitializeComponent();
            uc = userControl;
            callingControl = caller;
            Text = title;
            //Add the Specified User Control to the form
            pnlContent.Controls.Add(userControl);
        }
        private void frmPopup_Load(object sender, EventArgs e)
        {
            positionForm(callingControl);
        }
        private void positionForm(Control caller)
        {
            this.Top = caller.Top + 100;
            this.Left = caller.Left + 100;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Need to validate before closing
            //bool validated = uc.Validate();

            this.Close();
            DialogResult = DialogResult.OK;
        }


    }
}
