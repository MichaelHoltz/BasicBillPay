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
        List<HeaderItem> headerItems = new List<HeaderItem>();
        Label lastLabel = new Label();
        bool firstLabel = true;
        public CtrlHeader()
        {
            InitializeComponent();
        }
        public CtrlHeader(List<HeaderItem> headerItems)
        {
            InitializeComponent();
            this.headerItems = headerItems;
            lastLabel.BorderStyle = BorderStyle.FixedSingle;
            lastLabel.Left = 0;
            lastLabel.Width = 0; 


        }
        private void CtrlHeader_Load(object sender, EventArgs e)
        {
            foreach (HeaderItem item in headerItems)
            {
                //if (firstLabel)
                //{
                //    item.Width += item.SourceLeft;
                //    firstLabel = false;
                //}
                AddHeaderItem(item);
            }
        }
        private void AddHeaderItem(HeaderItem headerItem)
        {
            Label lblHeaderItem = new Label();
            //Copy / set from previous Label
            lblHeaderItem.BorderStyle = lastLabel.BorderStyle;

            int newStart = headerItem.SourceLeft;
            //Widen the last label 
            //lastLabel.Right;
            lblHeaderItem.Left = newStart;
            lblHeaderItem.Height = this.Height; // lastLabel.Height;

            lblHeaderItem.Text = headerItem.Title;
            lblHeaderItem.Width = headerItem.Width;
            lblHeaderItem.Top = 0;
            lblHeaderItem.Visible = true;
            Controls.Add(lblHeaderItem);
            lastLabel = lblHeaderItem;
        }
    }
}
