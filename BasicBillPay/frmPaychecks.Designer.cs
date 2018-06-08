namespace BasicBillPay
{
    partial class frmPaychecks
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
            this.flpPaychecks = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAddPayCheck = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPaychecks
            // 
            this.flpPaychecks.AutoScroll = true;
            this.flpPaychecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPaychecks.Location = new System.Drawing.Point(0, 39);
            this.flpPaychecks.Name = "flpPaychecks";
            this.flpPaychecks.Size = new System.Drawing.Size(983, 595);
            this.flpPaychecks.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnAddPayCheck);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(983, 39);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnAddPayCheck
            // 
            this.btnAddPayCheck.Location = new System.Drawing.Point(12, 10);
            this.btnAddPayCheck.Name = "btnAddPayCheck";
            this.btnAddPayCheck.Size = new System.Drawing.Size(105, 23);
            this.btnAddPayCheck.TabIndex = 0;
            this.btnAddPayCheck.Text = "Add Paycheck";
            this.btnAddPayCheck.UseVisualStyleBackColor = true;
            this.btnAddPayCheck.Click += new System.EventHandler(this.btnAddPayCheck_Click);
            // 
            // frmPaychecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 634);
            this.Controls.Add(this.flpPaychecks);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Name = "frmPaychecks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paycheck Manager";
            this.Load += new System.EventHandler(this.frmPaychecks_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPaychecks;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnAddPayCheck;
    }
}