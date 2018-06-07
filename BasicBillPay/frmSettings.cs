using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Models;
namespace BasicBillPay
{
    public partial class frmSettings : Form
    {
        ApplicationSettings appSet;
        public frmSettings()
        {
            InitializeComponent();
        }
        internal frmSettings(ApplicationSettings appSettings)
        {
            InitializeComponent();
            appSet = appSettings;
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            tbDataFile.Text = appSet.DbPath;
        }
        private void btnGetDataFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                appSet.DbPath = openFileDialog1.FileName;
                tbDataFile.Text = appSet.DbPath;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            appSet.DbPath = tbDataFile.Text.Trim(); // If the user typed in a change
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
