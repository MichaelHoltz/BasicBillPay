using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicBillPay.Models;
using System.Windows.Forms;

namespace BasicBillPay.Controls
{
    public partial class CtrlSortableBase : UserControl
    {
        public event EventHandler IndexChanged;
        public event EventHandler ReorderIndexes;
        public event EventHandler ItemDeleted;
        public int ItemIndex { get; set; }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public CtrlSortableBase()
        {
            InitializeComponent();
        }

        public CtrlSortableBase(int itemIndex)
        {
            InitializeComponent();
            ItemIndex = itemIndex;
            lblIndex.Text = (ItemIndex + 1).ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemDeleted?.Invoke(this, new EventArgs()); // Only fire if there is a listener
            this.Parent.Controls.Remove(this); //Visually remove
        }
        /// <summary>
        /// Updates the Command Index if other commands were removed.
        /// </summary>
        /// <param name="newIndex"></param>
        public void UpdateIndex(int newIndex)
        {
            ItemIndex = newIndex;
            lblIndex.Text = (ItemIndex + 1).ToString();
            ReorderIndexes?.Invoke(this, new EventArgs());


        }
        private void CtrlSortableBase_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.Move);            //Start the Drag and Drop Operation
        }
        private void CtrlSortableBase_DragEnter(object sender, DragEventArgs e)
        {
            object o = getData(e);
            if (o != null && o is CtrlSortableBase)
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void CtrlSortableBase_DragDrop(object sender, DragEventArgs e)
        {
            object o = getData(e);
            if (o != null && o is CtrlSortableBase)
            {

                CtrlSortableBase ctrlToMove = (o as CtrlSortableBase);    //Object being Dragged 
                //FrameCommand dataToMove = ctrlToMove.Cmd;

                int lastCtrlIndex = this.Parent.Controls.IndexOf(ctrlToMove);   //Get the previous Control Index.
                int destIndex = this.Parent.Controls.IndexOf(this);             //Index of the Control we are dropping "On"
                if (lastCtrlIndex != destIndex)
                {
                    //List<CtrlSortableBase> masterList = (this.Parent.Parent as frmFrameEditor).frames[parentFrameIndex].Commands;     //Need the Parent list.. could be passed in to the Control or found this way
                    //HashSet<Payment> masterList = (this.Parent.Parent as frmMain).GetPayments()// .frames[parentFrameIndex].Commands;     //Need the Parent list.. could be passed in to the Control or found this way
                    ctrlToMove.Parent.Controls.SetChildIndex(ctrlToMove, destIndex);                // Physically Move Control

                    //masterList.RemoveAt(lastCtrlIndex);                                             // Remove list item at the old location (Its the old object)
                    //masterList.Insert(destIndex, dataToMove);                                       // Insert to the List
                    IndexChanged?.Invoke(this, new EventArgs()); // Only fire if there is a listener
                }
                
            }
        }

        /// <summary>
        /// getData based on type
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private object getData(DragEventArgs e)
        {
            object o;
            o = e.Data.GetData(typeof(CtrlPaymentItem));
            if (o == null)
            {
                //Examples from different application for different types
                //o = e.Data.GetData(typeof(FrameMessageCtrl));
                //if (o == null)
                //{
                //    o = e.Data.GetData(typeof(FrameRetryCtrl));
                //    if (o == null)
                //    {
                //        o = e.Data.GetData(typeof(FrameGapCtrl));
                //        if (o == null)
                //        {
                //            o = e.Data.GetData(typeof(FrameDIOCtrl));
                //            if (o == null)
                //            {
                //                o = e.Data.GetData(typeof(FrameLogCtrl));
                //                if (o == null)
                //                {
                //                    //Next Type for FrameCommandCtrl

                //                }
                //            }
                //        }
                //    }
                //}
            }
            return o;
        }


    }
}
