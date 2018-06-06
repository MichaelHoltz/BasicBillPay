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
            this.tbSplit1Account = new System.Windows.Forms.TextBox();
            this.tbSplit2Account = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(49, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 20);
            this.tbName.TabIndex = 0;
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(293, 0);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 1;
            this.cbPaidFrequency.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbPaidFrequency_DrawItem);
            this.cbPaidFrequency.SelectedIndexChanged += new System.EventHandler(this.cbPaidFrequency_SelectedIndexChanged);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(370, 0);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(64, 20);
            this.tbAmount.TabIndex = 2;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAmount.Leave += new System.EventHandler(this.tbAmount_Leave);
            // 
            // tbSplit1Amount
            // 
            this.tbSplit1Amount.Location = new System.Drawing.Point(585, 0);
            this.tbSplit1Amount.Name = "tbSplit1Amount";
            this.tbSplit1Amount.Size = new System.Drawing.Size(57, 20);
            this.tbSplit1Amount.TabIndex = 3;
            this.tbSplit1Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSplit1Amount.Leave += new System.EventHandler(this.tbSplit1Amount_Leave);
            // 
            // tbSplit2Amount
            // 
            this.tbSplit2Amount.Location = new System.Drawing.Point(799, 0);
            this.tbSplit2Amount.Name = "tbSplit2Amount";
            this.tbSplit2Amount.Size = new System.Drawing.Size(57, 20);
            this.tbSplit2Amount.TabIndex = 4;
            this.tbSplit2Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSplit2Amount.Leave += new System.EventHandler(this.tbSplit2Amount_Leave);
            // 
            // tbSplit1Account
            // 
            this.tbSplit1Account.Location = new System.Drawing.Point(448, 0);
            this.tbSplit1Account.Name = "tbSplit1Account";
            this.tbSplit1Account.Size = new System.Drawing.Size(131, 20);
            this.tbSplit1Account.TabIndex = 9;
            // 
            // tbSplit2Account
            // 
            this.tbSplit2Account.Location = new System.Drawing.Point(649, 0);
            this.tbSplit2Account.Name = "tbSplit2Account";
            this.tbSplit2Account.Size = new System.Drawing.Size(131, 20);
            this.tbSplit2Account.TabIndex = 10;
            // 
            // CtrlBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSplit2Account);
            this.Controls.Add(this.tbSplit1Account);
            this.Controls.Add(this.tbSplit2Amount);
            this.Controls.Add(this.tbSplit1Amount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.cbPaidFrequency);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlBudget";
            this.Size = new System.Drawing.Size(1000, 24);
            this.Load += new System.EventHandler(this.CtrlBudget_Load);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.cbPaidFrequency, 0);
            this.Controls.SetChildIndex(this.tbAmount, 0);
            this.Controls.SetChildIndex(this.tbSplit1Amount, 0);
            this.Controls.SetChildIndex(this.tbSplit2Amount, 0);
            this.Controls.SetChildIndex(this.tbSplit1Account, 0);
            this.Controls.SetChildIndex(this.tbSplit2Account, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbPaidFrequency;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbSplit1Amount;
        private System.Windows.Forms.TextBox tbSplit2Amount;
        private System.Windows.Forms.TextBox tbSplit1Account;
        private System.Windows.Forms.TextBox tbSplit2Account;
    }
}
