namespace BasicBillPay.Controls
{
    partial class CtrlPayment
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
            this.dtpDateDue = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePaid = new System.Windows.Forms.DateTimePicker();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDateDue
            // 
            this.dtpDateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDue.Location = new System.Drawing.Point(468, 0);
            this.dtpDateDue.MaxDate = new System.DateTime(2400, 12, 31, 0, 0, 0, 0);
            this.dtpDateDue.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDateDue.Name = "dtpDateDue";
            this.dtpDateDue.Size = new System.Drawing.Size(96, 20);
            this.dtpDateDue.TabIndex = 0;
            this.dtpDateDue.Value = new System.DateTime(2018, 12, 31, 11, 40, 0, 0);
            // 
            // dtpDatePaid
            // 
            this.dtpDatePaid.CustomFormat = "";
            this.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePaid.Location = new System.Drawing.Point(566, 0);
            this.dtpDatePaid.MaxDate = new System.DateTime(2400, 12, 31, 0, 0, 0, 0);
            this.dtpDatePaid.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDatePaid.Name = "dtpDatePaid";
            this.dtpDatePaid.Size = new System.Drawing.Size(96, 20);
            this.dtpDatePaid.TabIndex = 9;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(665, 0);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAmount.Size = new System.Drawing.Size(62, 20);
            this.tbAmount.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(138, 20);
            this.tbName.TabIndex = 11;
            // 
            // CtrlPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.dtpDatePaid);
            this.Controls.Add(this.dtpDateDue);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlPayment";
            this.Size = new System.Drawing.Size(1000, 40);
            this.Controls.SetChildIndex(this.dtpDateDue, 0);
            this.Controls.SetChildIndex(this.dtpDatePaid, 0);
            this.Controls.SetChildIndex(this.tbAmount, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateDue;
        private System.Windows.Forms.DateTimePicker dtpDatePaid;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbName;
    }
}
