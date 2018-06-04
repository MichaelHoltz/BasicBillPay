namespace BasicBillPay.Controls
{
    partial class CtrlAccount
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(307, 142);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(8, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(233, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(8, 59);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(233, 20);
            this.tbNumber.TabIndex = 3;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(5, 43);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(87, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Account Number";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(8, 99);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(342, 20);
            this.tbLink.TabIndex = 4;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(5, 83);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(65, 13);
            this.lblLink.TabIndex = 5;
            this.lblLink.Text = "Access Link";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(8, 139);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(127, 20);
            this.tbUserName.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(5, 123);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "User Name";
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(258, 20);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(92, 20);
            this.tbBalance.TabIndex = 2;
            this.tbBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBalance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBalance_KeyUp);
            this.tbBalance.Leave += new System.EventHandler(this.tbBalance_Leave);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(255, 4);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(95, 13);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "Estimated Balance";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Location = new System.Drawing.Point(331, 142);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(19, 13);
            this.lblIdValue.TabIndex = 11;
            this.lblIdValue.Text = "00";
            this.lblIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CtrlAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "CtrlAccount";
            this.Size = new System.Drawing.Size(356, 165);
            this.Load += new System.EventHandler(this.CtrlAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblIdValue;
    }
}
