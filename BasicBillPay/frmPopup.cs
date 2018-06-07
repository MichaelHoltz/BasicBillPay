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
            //If I sent in a form I want it to center on the form
            if (caller == null)
            {
                StartPosition = FormStartPosition.CenterScreen; // Easy Center 
            }
            else if (caller is Form)
            {
                StartPosition = FormStartPosition.CenterParent; // Easy Center 
            }
            else // Center it under the Control (Nested Controls cause problems)
            {
                StartPosition = FormStartPosition.Manual;
                int startLeft = 0;
                int startTop = 0;
                Control parent = caller;
                while (parent != null)
                {
                    startLeft += parent.Left;
                    startTop += parent.Top;
                    parent = parent.Parent;
                }
                //Point p = PointToClient(caller.ClientRectangle.Location);
                Location =  new Point(startLeft, startTop);
                int w = Width;
                int cw = caller.Width;
                int centerAdj = Math.Abs( cw / 2 - w / 2);
                int h = Height;
                Point clientScreenCtrl = PointToScreen(caller.Location);
                //Location = new Point(clientScreenCtrl.X - w / 2,  clientScreenCtrl.Y + caller.Height);
                Location = new Point(startLeft - centerAdj, clientScreenCtrl.Y + caller.Height);
                //Figure out if it's off screen and move it back on if necessary.
                MoveFormJustOnScreen(this);
            }

        }
        public void MoveFormJustOnScreen(Form form)
        {
            //Done if this passes.
            if (IsOnScreen(form))
                return;
            else
            {
                Screen activeScreen = FindActiveScreen(form); 
                int DeltaY = form.Bottom - activeScreen.WorkingArea.Bottom;
                int DeltaXr = activeScreen.WorkingArea.Right - form.Right;
                int DeltaXl = form.Left - activeScreen.WorkingArea.Left;

                if (DeltaXr < 0) // Off the Right hand Side..
                {
                    form.Location = new Point(form.Location.X + DeltaXr, form.Location.Y - DeltaY);
                }
                else if (DeltaXl < 0)
                {
                    form.Location = new Point(0, form.Location.Y - DeltaY);
                }
                else
                {
                    form.Location = new Point(form.Location.X, form.Location.Y - DeltaY);
                }

            }
        }
        /// <summary>
        /// Has Bugs for Multi Screen and if the Top Left is off the active screen need to figure something else out.. but normal cases work
        /// </summary>
        /// <param name="form"></param>
        /// <see cref="https://stackoverflow.com/questions/987018/determining-if-a-form-is-completely-off-screen?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa"/>
        /// <returns></returns>
        public bool IsOnScreen(Form form)
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                Rectangle formRectangle = new Rectangle(form.Left, form.Top, form.Width, form.Height);
                
                if (screen.WorkingArea.Contains(formRectangle))
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Has Bugs for Multi Screen and if the Top Left is off the active screen need to figure something else out.. but normal cases work
        /// </summary>
        /// <param name="form"></param>
        /// <see cref="https://stackoverflow.com/questions/987018/determining-if-a-form-is-completely-off-screen?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa"/>
        /// <returns></returns>
        public Screen FindActiveScreen(Form form)
        {
            Screen retScreen = null;
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                Point formTopLeft = new Point(form.Left, form.Top);

                if (screen.WorkingArea.Contains(formTopLeft))
                {
                    retScreen = screen;
                }
            }

            return retScreen;
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
