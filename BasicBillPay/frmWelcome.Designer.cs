namespace BasicBillPay
{
    partial class frmWelcome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbSecurityOptions = new System.Windows.Forms.GroupBox();
            this.ctrlPassword1 = new BasicBillPay.Controls.CtrlPasswordSetup();
            this.rbStoreUserPassword = new System.Windows.Forms.RadioButton();
            this.rbAutoEncrypt = new System.Windows.Forms.RadioButton();
            this.rbNoSecurity = new System.Windows.Forms.RadioButton();
            this.lblPrimaryPerson = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rbCashAccount = new System.Windows.Forms.RadioButton();
            this.rbCheckingAccount = new System.Windows.Forms.RadioButton();
            this.btnBegin = new System.Windows.Forms.Button();
            this.gbSecurityOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(15, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(449, 81);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Welcome Information - Set in Code";
            // 
            // gbSecurityOptions
            // 
            this.gbSecurityOptions.BackColor = System.Drawing.Color.Transparent;
            this.gbSecurityOptions.Controls.Add(this.ctrlPassword1);
            this.gbSecurityOptions.Controls.Add(this.rbStoreUserPassword);
            this.gbSecurityOptions.Controls.Add(this.rbAutoEncrypt);
            this.gbSecurityOptions.Controls.Add(this.rbNoSecurity);
            this.gbSecurityOptions.Location = new System.Drawing.Point(18, 100);
            this.gbSecurityOptions.Name = "gbSecurityOptions";
            this.gbSecurityOptions.Size = new System.Drawing.Size(251, 189);
            this.gbSecurityOptions.TabIndex = 1;
            this.gbSecurityOptions.TabStop = false;
            this.gbSecurityOptions.Text = "Security Options";
            // 
            // ctrlPassword1
            // 
            this.ctrlPassword1.Location = new System.Drawing.Point(42, 89);
            this.ctrlPassword1.MinimumSize = new System.Drawing.Size(176, 48);
            this.ctrlPassword1.Name = "ctrlPassword1";
            this.ctrlPassword1.Password = null;
            this.ctrlPassword1.Size = new System.Drawing.Size(176, 95);
            this.ctrlPassword1.TabIndex = 3;
            // 
            // rbStoreUserPassword
            // 
            this.rbStoreUserPassword.AutoSize = true;
            this.rbStoreUserPassword.Location = new System.Drawing.Point(18, 66);
            this.rbStoreUserPassword.Name = "rbStoreUserPassword";
            this.rbStoreUserPassword.Size = new System.Drawing.Size(226, 17);
            this.rbStoreUserPassword.TabIndex = 2;
            this.rbStoreUserPassword.Text = "User Supplied Password Every Time (Best)";
            this.rbStoreUserPassword.UseVisualStyleBackColor = true;
            // 
            // rbAutoEncrypt
            // 
            this.rbAutoEncrypt.AutoSize = true;
            this.rbAutoEncrypt.Location = new System.Drawing.Point(18, 44);
            this.rbAutoEncrypt.Name = "rbAutoEncrypt";
            this.rbAutoEncrypt.Size = new System.Drawing.Size(123, 17);
            this.rbAutoEncrypt.TabIndex = 1;
            this.rbAutoEncrypt.Text = "Auto Encrypt (Better)";
            this.rbAutoEncrypt.UseVisualStyleBackColor = true;
            // 
            // rbNoSecurity
            // 
            this.rbNoSecurity.AutoSize = true;
            this.rbNoSecurity.Checked = true;
            this.rbNoSecurity.Location = new System.Drawing.Point(18, 24);
            this.rbNoSecurity.Name = "rbNoSecurity";
            this.rbNoSecurity.Size = new System.Drawing.Size(176, 17);
            this.rbNoSecurity.TabIndex = 0;
            this.rbNoSecurity.TabStop = true;
            this.rbNoSecurity.Text = "No Security (Not recommended)";
            this.rbNoSecurity.UseVisualStyleBackColor = true;
            // 
            // lblPrimaryPerson
            // 
            this.lblPrimaryPerson.AutoSize = true;
            this.lblPrimaryPerson.Location = new System.Drawing.Point(304, 114);
            this.lblPrimaryPerson.Name = "lblPrimaryPerson";
            this.lblPrimaryPerson.Size = new System.Drawing.Size(60, 13);
            this.lblPrimaryPerson.TabIndex = 2;
            this.lblPrimaryPerson.Text = "Your Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(307, 130);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 20);
            this.tbName.TabIndex = 3;
            // 
            // rbCashAccount
            // 
            this.rbCashAccount.AutoSize = true;
            this.rbCashAccount.BackColor = System.Drawing.Color.Transparent;
            this.rbCashAccount.Location = new System.Drawing.Point(307, 179);
            this.rbCashAccount.Name = "rbCashAccount";
            this.rbCashAccount.Size = new System.Drawing.Size(92, 17);
            this.rbCashAccount.TabIndex = 4;
            this.rbCashAccount.Text = "Cash Account";
            this.rbCashAccount.UseVisualStyleBackColor = false;
            // 
            // rbCheckingAccount
            // 
            this.rbCheckingAccount.AutoSize = true;
            this.rbCheckingAccount.BackColor = System.Drawing.Color.Transparent;
            this.rbCheckingAccount.Checked = true;
            this.rbCheckingAccount.Location = new System.Drawing.Point(307, 156);
            this.rbCheckingAccount.Name = "rbCheckingAccount";
            this.rbCheckingAccount.Size = new System.Drawing.Size(113, 17);
            this.rbCheckingAccount.TabIndex = 5;
            this.rbCheckingAccount.TabStop = true;
            this.rbCheckingAccount.Text = "Checking Account";
            this.rbCheckingAccount.UseVisualStyleBackColor = false;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(317, 215);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 6;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // frmWelcome
            // 
            this.AcceptButton = this.btnBegin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(478, 332);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.rbCheckingAccount);
            this.Controls.Add(this.rbCashAccount);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPrimaryPerson);
            this.Controls.Add(this.gbSecurityOptions);
            this.Controls.Add(this.lblInfo);
            this.DoubleBuffered = true;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Bill Pay - Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWelcome_FormClosing);
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.gbSecurityOptions.ResumeLayout(false);
            this.gbSecurityOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbSecurityOptions;
        private System.Windows.Forms.RadioButton rbStoreUserPassword;
        private System.Windows.Forms.RadioButton rbAutoEncrypt;
        private System.Windows.Forms.RadioButton rbNoSecurity;
        private Controls.CtrlPasswordSetup ctrlPassword1;
        private System.Windows.Forms.Label lblPrimaryPerson;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rbCashAccount;
        private System.Windows.Forms.RadioButton rbCheckingAccount;
        private System.Windows.Forms.Button btnBegin;
    }
}