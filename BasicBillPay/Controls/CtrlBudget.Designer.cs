namespace BasicBillPay.Controls
{
    partial class CtrlBudget
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
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbSplit1Amount = new System.Windows.Forms.TextBox();
            this.tbSplit2Amount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(28, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 0;
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(190, 0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(149, 21);
            this.cbPaidFrequency.TabIndex = 1;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(345, 0);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(94, 20);
            this.tbAmount.TabIndex = 2;
            this.tbAmount.Leave += new System.EventHandler(this.tbAmount_Leave);
            // 
            // tbSplit1Amount
            // 
            this.tbSplit1Amount.Location = new System.Drawing.Point(463, 0);
            this.tbSplit1Amount.Name = "tbSplit1Amount";
            this.tbSplit1Amount.Size = new System.Drawing.Size(94, 20);
            this.tbSplit1Amount.TabIndex = 3;
            this.tbSplit1Amount.Leave += new System.EventHandler(this.tbSplit1Amount_Leave);
            // 
            // tbSplit2Amount
            // 
            this.tbSplit2Amount.Location = new System.Drawing.Point(582, 0);
            this.tbSplit2Amount.Name = "tbSplit2Amount";
            this.tbSplit2Amount.Size = new System.Drawing.Size(94, 20);
            this.tbSplit2Amount.TabIndex = 4;
            this.tbSplit2Amount.Leave += new System.EventHandler(this.tbSplit2Amount_Leave);
            // 
            // CtrlBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSplit2Amount);
            this.Controls.Add(this.tbSplit1Amount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.cbPaidFrequency);
            this.Controls.Add(this.tbName);
            this.Name = "CtrlBudget";
            this.Size = new System.Drawing.Size(1000, 20);
            this.Load += new System.EventHandler(this.CtrlBudget_Load);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.cbPaidFrequency, 0);
            this.Controls.SetChildIndex(this.tbAmount, 0);
            this.Controls.SetChildIndex(this.tbSplit1Amount, 0);
            this.Controls.SetChildIndex(this.tbSplit2Amount, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbPaidFrequency;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbSplit1Amount;
        private System.Windows.Forms.TextBox tbSplit2Amount;
    }
}
