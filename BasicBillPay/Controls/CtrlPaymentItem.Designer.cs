namespace BasicBillPay.Controls
{
    partial class CtrlPaymentItem
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
            this.cbPaidFrequency = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.catbPayTo = new BasicBillPay.Controls.CtrlAccountTextBox();
            this.catbPayFrom = new BasicBillPay.Controls.CtrlAccountTextBox();
            this.cctbAmount = new BasicBillPay.Controls.CtrlCurrencyTextBox();
            this.SuspendLayout();
            // 
            // dtpDateDue
            // 
            this.dtpDateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDue.Location = new System.Drawing.Point(486, 0);
            this.dtpDateDue.MaxDate = new System.DateTime(2400, 12, 31, 0, 0, 0, 0);
            this.dtpDateDue.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDateDue.Name = "dtpDateDue";
            this.dtpDateDue.Size = new System.Drawing.Size(96, 20);
            this.dtpDateDue.TabIndex = 5;
            this.dtpDateDue.Tag = "Due Date";
            this.dtpDateDue.Value = new System.DateTime(2018, 12, 31, 11, 40, 0, 0);
            // 
            // dtpDatePaid
            // 
            this.dtpDatePaid.CustomFormat = "";
            this.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePaid.Location = new System.Drawing.Point(583, 0);
            this.dtpDatePaid.MaxDate = new System.DateTime(2400, 12, 31, 0, 0, 0, 0);
            this.dtpDatePaid.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDatePaid.Name = "dtpDatePaid";
            this.dtpDatePaid.Size = new System.Drawing.Size(96, 20);
            this.dtpDatePaid.TabIndex = 6;
            this.dtpDatePaid.Tag = "Last Paid";
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(414, 0);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 4;
            this.cbPaidFrequency.Tag = "Frequency";
            this.cbPaidFrequency.SelectedIndexChanged += new System.EventHandler(this.cbPaidFrequency_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(960, -1);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(39, 23);
            this.btnPay.TabIndex = 9;
            this.btnPay.Tag = "Pay";
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // catbPayTo
            // 
            this.catbPayTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catbPayTo.Location = new System.Drawing.Point(48, 0);
            this.catbPayTo.Margin = new System.Windows.Forms.Padding(0);
            this.catbPayTo.MinimumSize = new System.Drawing.Size(40, 20);
            this.catbPayTo.Name = "catbPayTo";
            this.catbPayTo.Size = new System.Drawing.Size(182, 20);
            this.catbPayTo.TabIndex = 2;
            this.catbPayTo.Tag = "Pay To";
            // 
            // catbPayFrom
            // 
            this.catbPayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catbPayFrom.Location = new System.Drawing.Point(231, 0);
            this.catbPayFrom.Margin = new System.Windows.Forms.Padding(0);
            this.catbPayFrom.MinimumSize = new System.Drawing.Size(40, 20);
            this.catbPayFrom.Name = "catbPayFrom";
            this.catbPayFrom.Size = new System.Drawing.Size(182, 20);
            this.catbPayFrom.TabIndex = 3;
            this.catbPayFrom.Tag = "Pay From";
            // 
            // cctbAmount
            // 
            this.cctbAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cctbAmount.Location = new System.Drawing.Point(680, 0);
            this.cctbAmount.Margin = new System.Windows.Forms.Padding(0);
            this.cctbAmount.Name = "cctbAmount";
            this.cctbAmount.Size = new System.Drawing.Size(72, 20);
            this.cctbAmount.TabIndex = 7;
            this.cctbAmount.Tag = "Amount";
            this.cctbAmount.Value = 0F;
            this.cctbAmount.ValueChanged += new System.EventHandler(this.cctbAmount_ValueChanged);
            // 
            // CtrlPaymentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.cctbAmount);
            this.Controls.Add(this.catbPayFrom);
            this.Controls.Add(this.catbPayTo);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cbPaidFrequency);
            this.Controls.Add(this.dtpDatePaid);
            this.Controls.Add(this.dtpDateDue);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlPaymentItem";
            this.Size = new System.Drawing.Size(1000, 22);
            this.Load += new System.EventHandler(this.CtrlPayment_Load);
            this.Controls.SetChildIndex(this.dtpDateDue, 0);
            this.Controls.SetChildIndex(this.dtpDatePaid, 0);
            this.Controls.SetChildIndex(this.cbPaidFrequency, 0);
            this.Controls.SetChildIndex(this.btnPay, 0);
            this.Controls.SetChildIndex(this.catbPayTo, 0);
            this.Controls.SetChildIndex(this.catbPayFrom, 0);
            this.Controls.SetChildIndex(this.cctbAmount, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateDue;
        private System.Windows.Forms.DateTimePicker dtpDatePaid;
        private System.Windows.Forms.ComboBox cbPaidFrequency;
        private System.Windows.Forms.Button btnPay;
        private CtrlAccountTextBox catbPayTo;
        private CtrlAccountTextBox catbPayFrom;
        private CtrlCurrencyTextBox cctbAmount;
    }
}
