namespace BasicBillPay
{
    partial class frmPeopleManager
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
            this.lbPeople = new System.Windows.Forms.ListBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.clbPaychecks = new System.Windows.Forms.CheckedListBox();
            this.lblPaychecks = new System.Windows.Forms.Label();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.clbAccounts = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lbPeople
            // 
            this.lbPeople.FormattingEnabled = true;
            this.lbPeople.Location = new System.Drawing.Point(12, 36);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(146, 121);
            this.lbPeople.TabIndex = 0;
            this.lbPeople.SelectedIndexChanged += new System.EventHandler(this.lbPeople_SelectedIndexChanged);
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(15, 19);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(40, 13);
            this.lblPeople.TabIndex = 1;
            this.lblPeople.Text = "People";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(193, 92);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(159, 23);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Add / Update Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(190, 20);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(35, 13);
            this.lblPersonName.TabIndex = 3;
            this.lblPersonName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(193, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(159, 20);
            this.tbName.TabIndex = 4;
            // 
            // clbPaychecks
            // 
            this.clbPaychecks.CheckOnClick = true;
            this.clbPaychecks.FormattingEnabled = true;
            this.clbPaychecks.Location = new System.Drawing.Point(376, 36);
            this.clbPaychecks.Name = "clbPaychecks";
            this.clbPaychecks.Size = new System.Drawing.Size(169, 79);
            this.clbPaychecks.TabIndex = 5;
            // 
            // lblPaychecks
            // 
            this.lblPaychecks.AutoSize = true;
            this.lblPaychecks.Location = new System.Drawing.Point(378, 17);
            this.lblPaychecks.Name = "lblPaychecks";
            this.lblPaychecks.Size = new System.Drawing.Size(60, 13);
            this.lblPaychecks.TabIndex = 6;
            this.lblPaychecks.Text = "Paychecks";
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(569, 17);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(52, 13);
            this.lblAccounts.TabIndex = 8;
            this.lblAccounts.Text = "Accounts";
            // 
            // clbAccounts
            // 
            this.clbAccounts.CheckOnClick = true;
            this.clbAccounts.FormattingEnabled = true;
            this.clbAccounts.Location = new System.Drawing.Point(567, 36);
            this.clbAccounts.Name = "clbAccounts";
            this.clbAccounts.Size = new System.Drawing.Size(169, 79);
            this.clbAccounts.TabIndex = 7;
            // 
            // frmPeopleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 170);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.clbAccounts);
            this.Controls.Add(this.lblPaychecks);
            this.Controls.Add(this.clbPaychecks);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.lbPeople);
            this.DoubleBuffered = true;
            this.Name = "frmPeopleManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "People Manager";
            this.Load += new System.EventHandler(this.frmPeopleManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPeople;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckedListBox clbPaychecks;
        private System.Windows.Forms.Label lblPaychecks;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.CheckedListBox clbAccounts;
    }
}