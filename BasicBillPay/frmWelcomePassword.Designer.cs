namespace BasicBillPay
{
    partial class frmWelcomePassword
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
            this.components = new System.ComponentModel.Container();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ctrlPasswordEnter1 = new BasicBillPay.Controls.CtrlPasswordEnter();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPasswordSetup1 = new BasicBillPay.Controls.CtrlPasswordSetup();
            this.cbEncryptionType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(1, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(390, 60);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info Set in Code";
            // 
            // ctrlPasswordEnter1
            // 
            this.ctrlPasswordEnter1.Location = new System.Drawing.Point(12, 103);
            this.ctrlPasswordEnter1.Name = "ctrlPasswordEnter1";
            this.ctrlPasswordEnter1.Size = new System.Drawing.Size(178, 51);
            this.ctrlPasswordEnter1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(271, 157);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPasswordSetup1
            // 
            this.ctrlPasswordSetup1.Location = new System.Drawing.Point(12, 153);
            this.ctrlPasswordSetup1.MinimumSize = new System.Drawing.Size(176, 48);
            this.ctrlPasswordSetup1.Name = "ctrlPasswordSetup1";
            this.ctrlPasswordSetup1.Password = null;
            this.ctrlPasswordSetup1.Size = new System.Drawing.Size(176, 96);
            this.ctrlPasswordSetup1.TabIndex = 3;
            // 
            // cbEncryptionType
            // 
            this.cbEncryptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncryptionType.FormattingEnabled = true;
            this.cbEncryptionType.Location = new System.Drawing.Point(12, 76);
            this.cbEncryptionType.Name = "cbEncryptionType";
            this.cbEncryptionType.Size = new System.Drawing.Size(136, 21);
            this.cbEncryptionType.TabIndex = 4;
            // 
            // frmWelcomePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 261);
            this.Controls.Add(this.cbEncryptionType);
            this.Controls.Add(this.ctrlPasswordSetup1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ctrlPasswordEnter1);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmWelcomePassword";
            this.Text = "Basic Bill Pay Welcome: Password Required";
            this.Load += new System.EventHandler(this.frmWelcomePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private Controls.CtrlPasswordEnter ctrlPasswordEnter1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controls.CtrlPasswordSetup ctrlPasswordSetup1;
        private System.Windows.Forms.ComboBox cbEncryptionType;
    }
}