namespace BasicBillPay
{
    partial class frmSettings
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDataFile = new System.Windows.Forms.Label();
            this.tbDataFile = new System.Windows.Forms.TextBox();
            this.btnGetDataFile = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.DefaultExt = "bbp";
            this.openFileDialog1.FileName = "myBills";
            this.openFileDialog1.Filter = "BasicBillPay|*.bbp|Json Files|*.json";
            this.openFileDialog1.Title = "Select Database File";
            // 
            // lblDataFile
            // 
            this.lblDataFile.AutoSize = true;
            this.lblDataFile.Location = new System.Drawing.Point(16, 16);
            this.lblDataFile.Name = "lblDataFile";
            this.lblDataFile.Size = new System.Drawing.Size(49, 13);
            this.lblDataFile.TabIndex = 0;
            this.lblDataFile.Text = "Data File";
            // 
            // tbDataFile
            // 
            this.tbDataFile.Location = new System.Drawing.Point(16, 35);
            this.tbDataFile.Name = "tbDataFile";
            this.tbDataFile.Size = new System.Drawing.Size(378, 20);
            this.tbDataFile.TabIndex = 1;
            // 
            // btnGetDataFile
            // 
            this.btnGetDataFile.Location = new System.Drawing.Point(400, 35);
            this.btnGetDataFile.Name = "btnGetDataFile";
            this.btnGetDataFile.Size = new System.Drawing.Size(75, 23);
            this.btnGetDataFile.TabIndex = 2;
            this.btnGetDataFile.Text = "Open File";
            this.btnGetDataFile.UseVisualStyleBackColor = true;
            this.btnGetDataFile.Click += new System.EventHandler(this.btnGetDataFile_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(353, 95);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(39, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(414, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(486, 137);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnGetDataFile);
            this.Controls.Add(this.tbDataFile);
            this.Controls.Add(this.lblDataFile);
            this.DoubleBuffered = true;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDataFile;
        private System.Windows.Forms.TextBox tbDataFile;
        private System.Windows.Forms.Button btnGetDataFile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}