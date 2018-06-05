namespace BasicBillPay
{
    partial class frmMain
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
            this.flpBills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flpBudget = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBudget = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbTotal2 = new System.Windows.Forms.TextBox();
            this.tbBudgetTotal = new System.Windows.Forms.TextBox();
            this.lblAccount1 = new System.Windows.Forms.Label();
            this.lblAccount2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpBills
            // 
            this.flpBills.AllowDrop = true;
            this.flpBills.AutoScroll = true;
            this.flpBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBills.Location = new System.Drawing.Point(103, 78);
            this.flpBills.Name = "flpBills";
            this.flpBills.Size = new System.Drawing.Size(1003, 291);
            this.flpBills.TabIndex = 0;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddBill.Location = new System.Drawing.Point(8, 78);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(89, 31);
            this.btnAddBill.TabIndex = 1;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 592);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flpBudget
            // 
            this.flpBudget.AllowDrop = true;
            this.flpBudget.AutoScroll = true;
            this.flpBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBudget.Location = new System.Drawing.Point(103, 409);
            this.flpBudget.Name = "flpBudget";
            this.flpBudget.Size = new System.Drawing.Size(1003, 420);
            this.flpBudget.TabIndex = 4;
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.Yellow;
            this.btnAddBudget.Location = new System.Drawing.Point(8, 409);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(89, 31);
            this.btnAddBudget.TabIndex = 5;
            this.btnAddBudget.Text = "Add Budget";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudget_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(889, 17);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(72, 20);
            this.tbTotal.TabIndex = 6;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotal2
            // 
            this.tbTotal2.Location = new System.Drawing.Point(889, 43);
            this.tbTotal2.Name = "tbTotal2";
            this.tbTotal2.Size = new System.Drawing.Size(72, 20);
            this.tbTotal2.TabIndex = 7;
            this.tbTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbBudgetTotal
            // 
            this.tbBudgetTotal.Location = new System.Drawing.Point(437, 383);
            this.tbBudgetTotal.Name = "tbBudgetTotal";
            this.tbBudgetTotal.Size = new System.Drawing.Size(72, 20);
            this.tbBudgetTotal.TabIndex = 8;
            this.tbBudgetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccount1
            // 
            this.lblAccount1.AutoSize = true;
            this.lblAccount1.Location = new System.Drawing.Point(812, 20);
            this.lblAccount1.Name = "lblAccount1";
            this.lblAccount1.Size = new System.Drawing.Size(64, 13);
            this.lblAccount1.TabIndex = 9;
            this.lblAccount1.Text = "M Checking";
            // 
            // lblAccount2
            // 
            this.lblAccount2.AutoSize = true;
            this.lblAccount2.Location = new System.Drawing.Point(812, 46);
            this.lblAccount2.Name = "lblAccount2";
            this.lblAccount2.Size = new System.Drawing.Size(62, 13);
            this.lblAccount2.TabIndex = 10;
            this.lblAccount2.Text = "C Checking";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(55, 23);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 950);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAccount2);
            this.Controls.Add(this.lblAccount1);
            this.Controls.Add(this.tbBudgetTotal);
            this.Controls.Add(this.tbTotal2);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnAddBudget);
            this.Controls.Add(this.flpBudget);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.flpBills);
            this.Name = "frmMain";
            this.Text = "Basic Bill Pay (and Budget)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBills;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flpBudget;
        private System.Windows.Forms.Button btnAddBudget;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbTotal2;
        private System.Windows.Forms.TextBox tbBudgetTotal;
        private System.Windows.Forms.Label lblAccount1;
        private System.Windows.Forms.Label lblAccount2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSettings;
    }
}

