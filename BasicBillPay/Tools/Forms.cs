using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicBillPay.Controls;
namespace BasicBillPay.Tools
{
    /// <summary>
    /// Helper class for Forms
    /// </summary>
    internal static class Forms
    {

        internal static DialogResult ShowPopupControl(UserControl userControl, String title, Control parent)
        {
            frmPopup fp = new frmPopup(title, ref userControl, parent); // Center under Begin Button.
            return fp.ShowDialog();
        }
    }
}
