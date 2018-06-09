namespace BasicBillPay.Controls
{
    partial class CtrlCurrencyTextBox
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
            this.tbCurrency = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCurrency
            // 
            this.tbCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrency.Location = new System.Drawing.Point(0, 0);
            this.tbCurrency.Margin = new System.Windows.Forms.Padding(0);
            this.tbCurrency.Name = "tbCurrency";
            this.tbCurrency.Size = new System.Drawing.Size(66, 20);
            this.tbCurrency.TabIndex = 0;
            this.tbCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCurrency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCurrency_KeyUp);
            this.tbCurrency.Leave += new System.EventHandler(this.tbCurrency_Leave);
            this.tbCurrency.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrency_Validating);
            this.tbCurrency.Validated += new System.EventHandler(this.tbCurrency_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CtrlCurrencyTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCurrency);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlCurrencyTextBox";
            this.Size = new System.Drawing.Size(66, 20);
            this.BackColorChanged += new System.EventHandler(this.CtrlCurrencyTextBox_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrency;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
