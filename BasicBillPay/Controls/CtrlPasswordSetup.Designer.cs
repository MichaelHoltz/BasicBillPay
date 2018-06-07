namespace BasicBillPay.Controls
{
    partial class CtrlPasswordSetup
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
            this.components = new System.ComponentModel.Container();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.epPasswordLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.epMatchingPasswords = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epPasswordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMatchingPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(6, 25);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(131, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            this.tbPassword.Validated += new System.EventHandler(this.tbPassword_Validated);
            // 
            // epPasswordLength
            // 
            this.epPasswordLength.ContainerControl = this;
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Location = new System.Drawing.Point(6, 63);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.Size = new System.Drawing.Size(131, 20);
            this.tbPasswordConfirm.TabIndex = 3;
            this.tbPasswordConfirm.UseSystemPasswordChar = true;
            this.tbPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.tbPasswordConfirm_Validating);
            this.tbPasswordConfirm.Validated += new System.EventHandler(this.tbPasswordConfirm_Validated);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(3, 47);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // epMatchingPasswords
            // 
            this.epMatchingPasswords.ContainerControl = this;
            // 
            // CtrlPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(176, 48);
            this.Name = "CtrlPassword";
            this.Size = new System.Drawing.Size(176, 96);
            this.Load += new System.EventHandler(this.CtrlPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epPasswordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMatchingPasswords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ErrorProvider epPasswordLength;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.ErrorProvider epMatchingPasswords;
    }
}
