using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Models;
namespace BasicBillPay.Controls
{
    public partial class CtrlHeader : UserControl
    {
        public CtrlHeader()
        {
            InitializeComponent();


        }

        private void CtrlHeader_Load(object sender, EventArgs e)
        {
            HeaderItem hi1 = new HeaderItem();
            hi1.Title = "Test 1 2 3";
            hi1.Width = 60;

            Label lblhi1 = new Label();
            //Copy / set from previous Label
            lblhi1.BorderStyle = lblDelete.BorderStyle;
            lblhi1.Left = lblDelete.Right;
            lblhi1.Height = lblDelete.Height;

            lblhi1.Text = hi1.Title;
            lblhi1.Width = hi1.Width;
            lblhi1.Top = 0;
            lblhi1.Visible = true;
            Controls.Add(lblhi1);
        }
        //public CtrlHeader()
        //{

        //}
    }
}
