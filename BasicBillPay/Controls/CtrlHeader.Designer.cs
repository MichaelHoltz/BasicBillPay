namespace BasicBillPay.Controls
{
    partial class CtrlHeader
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDelete.Location = new System.Drawing.Point(0, 0);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(95, 22);
            this.lblDelete.TabIndex = 0;
            this.lblDelete.Text = "Order";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CtrlHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDelete);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlHeader";
            this.Size = new System.Drawing.Size(1000, 22);
            this.Load += new System.EventHandler(this.CtrlHeader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDelete;
    }
}
