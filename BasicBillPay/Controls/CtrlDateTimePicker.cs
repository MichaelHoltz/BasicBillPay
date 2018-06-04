using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicBillPay.Controls
{
    /// <summary>
    /// Extended DateTimePicker to set BackColor
    /// </summary>
    public partial class CtrlDateTimePicker : DateTimePicker
    {
        private Color _backColor;
        public override Color BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
                this.Invalidate();
            }
        }
        public CtrlDateTimePicker()
        {
            InitializeComponent();
            _backColor = Color.Red;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        const int WM_ERASEBKGND = 0x14;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_ERASEBKGND)
            {
                using (var g = Graphics.FromHdc(m.WParam))
                {
                    using (var b = new SolidBrush(_backColor))
                    {
                        g.FillRectangle(b, ClientRectangle);
                    }
                }
                return;
            }

            base.WndProc(ref m);
        }
    }
}
