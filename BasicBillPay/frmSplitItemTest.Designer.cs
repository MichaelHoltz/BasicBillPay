namespace BasicBillPay
{
    partial class frmSplitItemTest
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
            this.tbSplit1 = new System.Windows.Forms.TextBox();
            this.tbSplit2 = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSplit1
            // 
            this.tbSplit1.Location = new System.Drawing.Point(151, 17);
            this.tbSplit1.Name = "tbSplit1";
            this.tbSplit1.Size = new System.Drawing.Size(100, 20);
            this.tbSplit1.TabIndex = 0;
            this.tbSplit1.Leave += new System.EventHandler(this.tbSplit1_Leave);
            // 
            // tbSplit2
            // 
            this.tbSplit2.Location = new System.Drawing.Point(275, 17);
            this.tbSplit2.Name = "tbSplit2";
            this.tbSplit2.Size = new System.Drawing.Size(100, 20);
            this.tbSplit2.TabIndex = 1;
            this.tbSplit2.Leave += new System.EventHandler(this.tbSplit2_Leave);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(36, 17);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 2;
            this.tbTotal.Leave += new System.EventHandler(this.tbTotal_Leave);
            // 
            // frmSplitItemTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 261);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbSplit2);
            this.Controls.Add(this.tbSplit1);
            this.Name = "frmSplitItemTest";
            this.Text = "frmSplitItemTest";
            this.Load += new System.EventHandler(this.frmSplitItemTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSplit1;
        private System.Windows.Forms.TextBox tbSplit2;
        private System.Windows.Forms.TextBox tbTotal;
    }
}