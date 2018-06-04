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
            this.tbPayFrom = new System.Windows.Forms.TextBox();
            this.cbPaidFrequency = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpDateDue
            // 
            this.dtpDateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDue.Location = new System.Drawing.Point(579, 0);
            this.dtpDateDue.MaxDate = new System.DateTime(2400, 12, 31, 0, 0, 0, 0);
            this.dtpDateDue.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDateDue.Name = "dtpDateDue";
            this.dtpDateDue.Size = new System.Drawing.Size(96, 20);
            this.dtpDateDue.TabIndex = 3;
            this.dtpDateDue.Value = new System.DateTime(2018, 12, 31, 11, 40, 0, 0);
            // 
            // dtpDatePaid
            // 
            this.dtpDatePaid.CustomFormat = "";
            this.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePaid.Location = new System.Drawing.Point(677, 0);
            this.dtpDatePaid.MaxDate = new System.DateTime(2400, 12, 31, 0, 0, 0, 0);
            this.dtpDatePaid.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDatePaid.Name = "dtpDatePaid";
            this.dtpDatePaid.Size = new System.Drawing.Size(96, 20);
            this.dtpDatePaid.TabIndex = 4;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(776, 0);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(62, 20);
            this.tbAmount.TabIndex = 5;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAmount_KeyUp);
            this.tbAmount.Leave += new System.EventHandler(this.tbAmount_Leave);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(50, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(182, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseDoubleClick);
            // 
            // tbPayFrom
            // 
            this.tbPayFrom.Location = new System.Drawing.Point(232, 0);
            this.tbPayFrom.Name = "tbPayFrom";
            this.tbPayFrom.Size = new System.Drawing.Size(186, 20);
            this.tbPayFrom.TabIndex = 2;
            this.tbPayFrom.TextChanged += new System.EventHandler(this.tbPayFrom_TextChanged);
            this.tbPayFrom.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbPayFrom_MouseDoubleClick);
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(423, 0);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 9;
            this.cbPaidFrequency.SelectedIndexChanged += new System.EventHandler(this.cbPaidFrequency_SelectedIndexChanged);
            // 
            // CtrlPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.cbPaidFrequency);
            this.Controls.Add(this.tbPayFrom);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.dtpDatePaid);
            this.Controls.Add(this.dtpDateDue);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlPayment";
            this.Size = new System.Drawing.Size(1000, 22);
            this.Load += new System.EventHandler(this.CtrlPayment_Load);
            this.Controls.SetChildIndex(this.dtpDateDue, 0);
            this.Controls.SetChildIndex(this.dtpDatePaid, 0);
            this.Controls.SetChildIndex(this.tbAmount, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.tbPayFrom, 0);
            this.Controls.SetChildIndex(this.cbPaidFrequency, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateDue;
        private System.Windows.Forms.DateTimePicker dtpDatePaid;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPayFrom;
        private System.Windows.Forms.ComboBox cbPaidFrequency;
    }
}
