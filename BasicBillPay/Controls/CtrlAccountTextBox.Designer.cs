namespace BasicBillPay.Controls
{
    partial class CtrlAccountTextBox
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
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.btnAccountLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAccountName
            // 
            this.tbAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAccountName.Location = new System.Drawing.Point(0, 0);
            this.tbAccountName.Margin = new System.Windows.Forms.Padding(0);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(160, 20);
            this.tbAccountName.TabIndex = 0;
            this.tbAccountName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAccountName_KeyUp);
            // 
            // btnAccountLink
            // 
            this.btnAccountLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccountLink.Location = new System.Drawing.Point(160, 0);
            this.btnAccountLink.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccountLink.Name = "btnAccountLink";
            this.btnAccountLink.Size = new System.Drawing.Size(20, 18);
            this.btnAccountLink.TabIndex = 1;
            this.btnAccountLink.Text = "^";
            this.btnAccountLink.UseVisualStyleBackColor = true;
            this.btnAccountLink.Click += new System.EventHandler(this.btnAccountLink_Click);
            // 
            // CtrlAccountTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbAccountName);
            this.Controls.Add(this.btnAccountLink);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(40, 20);
            this.Name = "CtrlAccountTextBox";
            this.Size = new System.Drawing.Size(180, 18);
            this.Load += new System.EventHandler(this.CtrlAccountTextBox_Load);
            this.BackColorChanged += new System.EventHandler(this.CtrlAccountTextBox_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Button btnAccountLink;
    }
}
