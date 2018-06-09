namespace BasicBillPay.Controls
{
    partial class CtrlPaymentConfirm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAuthorization = new System.Windows.Forms.Label();
            this.tbAuthorization = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.epGeneral = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlCurrencyTextBox1 = new BasicBillPay.Controls.CtrlCurrencyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(7, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(109, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Payment Confirmation";
            // 
            // lblAuthorization
            // 
            this.lblAuthorization.AutoSize = true;
            this.lblAuthorization.Location = new System.Drawing.Point(8, 50);
            this.lblAuthorization.Name = "lblAuthorization";
            this.lblAuthorization.Size = new System.Drawing.Size(108, 13);
            this.lblAuthorization.TabIndex = 1;
            this.lblAuthorization.Text = "Authorization Number";
            // 
            // tbAuthorization
            // 
            this.tbAuthorization.Location = new System.Drawing.Point(10, 67);
            this.tbAuthorization.Multiline = true;
            this.tbAuthorization.Name = "tbAuthorization";
            this.tbAuthorization.Size = new System.Drawing.Size(263, 52);
            this.tbAuthorization.TabIndex = 2;
            this.tbAuthorization.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAuthorization_KeyUp);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(13, 141);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(120, 13);
            this.lblPaymentAmount.TabIndex = 3;
            this.lblPaymentAmount.Text = "Actual Payment Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(14, 158);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 4;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAmount_KeyUp);
            // 
            // epGeneral
            // 
            this.epGeneral.ContainerControl = this.ctrlCurrencyTextBox1;
            // 
            // ctrlCurrencyTextBox1
            // 
            this.ctrlCurrencyTextBox1.Location = new System.Drawing.Point(127, 158);
            this.ctrlCurrencyTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlCurrencyTextBox1.Name = "ctrlCurrencyTextBox1";
            this.ctrlCurrencyTextBox1.Size = new System.Drawing.Size(66, 20);
            this.ctrlCurrencyTextBox1.TabIndex = 5;
            this.ctrlCurrencyTextBox1.Value = 0F;

            // 
            // CtrlPaymentConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlCurrencyTextBox1);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.tbAuthorization);
            this.Controls.Add(this.lblAuthorization);
            this.Controls.Add(this.lblInfo);
            this.DoubleBuffered = true;
            this.Name = "CtrlPaymentConfirm";
            this.Size = new System.Drawing.Size(286, 204);
            this.Load += new System.EventHandler(this.CtrlPaymentConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAuthorization;
        private System.Windows.Forms.TextBox tbAuthorization;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ErrorProvider epGeneral;
        private CtrlCurrencyTextBox ctrlCurrencyTextBox1;
    }
}
