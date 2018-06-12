namespace BasicBillPay.Controls
{
    partial class CtrlBudgetItem
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbPaidFrequency = new System.Windows.Forms.ComboBox();
            this.tbSplit1Account = new System.Windows.Forms.TextBox();
            this.tbSplit2Account = new System.Windows.Forms.TextBox();
            this.cctbAmount = new BasicBillPay.Controls.CtrlCurrencyTextBox();
            this.cctbSplit1Amount = new BasicBillPay.Controls.CtrlCurrencyTextBox();
            this.cctbSplit2Amount = new BasicBillPay.Controls.CtrlCurrencyTextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(49, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 20);
            this.tbName.TabIndex = 2;
            this.tbName.Tag = "Budget Name";
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(291, 0);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 3;
            this.cbPaidFrequency.Tag = "Frequency";
            this.cbPaidFrequency.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbPaidFrequency_DrawItem);
            this.cbPaidFrequency.SelectedIndexChanged += new System.EventHandler(this.cbPaidFrequency_SelectedIndexChanged);
            // 
            // tbSplit1Account
            // 
            this.tbSplit1Account.Location = new System.Drawing.Point(429, 0);
            this.tbSplit1Account.Name = "tbSplit1Account";
            this.tbSplit1Account.Size = new System.Drawing.Size(131, 20);
            this.tbSplit1Account.TabIndex = 5;
            this.tbSplit1Account.Tag = "Person 1";
            // 
            // tbSplit2Account
            // 
            this.tbSplit2Account.Location = new System.Drawing.Point(626, 0);
            this.tbSplit2Account.Name = "tbSplit2Account";
            this.tbSplit2Account.Size = new System.Drawing.Size(131, 20);
            this.tbSplit2Account.TabIndex = 7;
            this.tbSplit2Account.Tag = "Person 2";
            // 
            // cctbAmount
            // 
            this.cctbAmount.Location = new System.Drawing.Point(363, 0);
            this.cctbAmount.Margin = new System.Windows.Forms.Padding(0);
            this.cctbAmount.Name = "cctbAmount";
            this.cctbAmount.Size = new System.Drawing.Size(66, 20);
            this.cctbAmount.TabIndex = 4;
            this.cctbAmount.Tag = "Budget Total";
            this.cctbAmount.Value = 0F;
            // 
            // cctbSplit1Amount
            // 
            this.cctbSplit1Amount.Location = new System.Drawing.Point(560, 0);
            this.cctbSplit1Amount.Margin = new System.Windows.Forms.Padding(0);
            this.cctbSplit1Amount.Name = "cctbSplit1Amount";
            this.cctbSplit1Amount.Size = new System.Drawing.Size(66, 20);
            this.cctbSplit1Amount.TabIndex = 6;
            this.cctbSplit1Amount.Tag = "Split 1";
            this.cctbSplit1Amount.Value = 0F;
            // 
            // cctbSplit2Amount
            // 
            this.cctbSplit2Amount.Location = new System.Drawing.Point(757, 0);
            this.cctbSplit2Amount.Margin = new System.Windows.Forms.Padding(0);
            this.cctbSplit2Amount.Name = "cctbSplit2Amount";
            this.cctbSplit2Amount.Size = new System.Drawing.Size(66, 20);
            this.cctbSplit2Amount.TabIndex = 8;
            this.cctbSplit2Amount.Tag = "Split 2 Amount";
            this.cctbSplit2Amount.Value = 0F;
            // 
            // CtrlBudgetItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.cctbSplit2Amount);
            this.Controls.Add(this.cctbSplit1Amount);
            this.Controls.Add(this.cctbAmount);
            this.Controls.Add(this.tbSplit2Account);
            this.Controls.Add(this.tbSplit1Account);
            this.Controls.Add(this.cbPaidFrequency);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlBudgetItem";
            this.Size = new System.Drawing.Size(1000, 22);
            this.Load += new System.EventHandler(this.CtrlBudget_Load);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.cbPaidFrequency, 0);
            this.Controls.SetChildIndex(this.tbSplit1Account, 0);
            this.Controls.SetChildIndex(this.tbSplit2Account, 0);
            this.Controls.SetChildIndex(this.cctbAmount, 0);
            this.Controls.SetChildIndex(this.cctbSplit1Amount, 0);
            this.Controls.SetChildIndex(this.cctbSplit2Amount, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbPaidFrequency;
        private System.Windows.Forms.TextBox tbSplit1Account;
        private System.Windows.Forms.TextBox tbSplit2Account;
        private CtrlCurrencyTextBox cctbAmount;
        private CtrlCurrencyTextBox cctbSplit1Amount;
        private CtrlCurrencyTextBox cctbSplit2Amount;
    }
}
