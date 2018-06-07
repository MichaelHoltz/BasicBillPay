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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.btnSave = new System.Windows.Forms.Button();
            this.flpBudget = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBudget = new System.Windows.Forms.Button();
            this.tbBudgetTotal = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPeople = new System.Windows.Forms.Button();
            this.flpPeopleBills = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 755);
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
            this.flpBudget.Location = new System.Drawing.Point(103, 714);
            this.flpBudget.Name = "flpBudget";
            this.flpBudget.Size = new System.Drawing.Size(1003, 239);
            this.flpBudget.TabIndex = 4;
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.Yellow;
            this.btnAddBudget.Location = new System.Drawing.Point(8, 714);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(89, 31);
            this.btnAddBudget.TabIndex = 5;
            this.btnAddBudget.Text = "Add Budget";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudget_Click);
            // 
            // tbBudgetTotal
            // 
            this.tbBudgetTotal.Location = new System.Drawing.Point(460, 688);
            this.tbBudgetTotal.Name = "tbBudgetTotal";
            this.tbBudgetTotal.Size = new System.Drawing.Size(72, 20);
            this.tbBudgetTotal.TabIndex = 8;
            this.tbBudgetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(473, 27);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(55, 23);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // chartBudget
            // 
            this.chartBudget.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartBudget.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartBudget.Legends.Add(legend2);
            this.chartBudget.Location = new System.Drawing.Point(1112, 714);
            this.chartBudget.Name = "chartBudget";
            this.chartBudget.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint3.IsValueShownAsLabel = true;
            dataPoint3.Label = "";
            dataPoint3.LabelFormat = "c0";
            dataPoint4.IsValueShownAsLabel = true;
            dataPoint4.LabelFormat = "c";
            dataPoint4.LegendText = "P1";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chartBudget.Series.Add(series2);
            this.chartBudget.Size = new System.Drawing.Size(476, 239);
            this.chartBudget.TabIndex = 20;
            this.chartBudget.Text = "chart2";
            // 
            // btnPeople
            // 
            this.btnPeople.Location = new System.Drawing.Point(534, 27);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(57, 23);
            this.btnPeople.TabIndex = 22;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // flpPeopleBills
            // 
            this.flpPeopleBills.AutoScroll = true;
            this.flpPeopleBills.Location = new System.Drawing.Point(2, 55);
            this.flpPeopleBills.Name = "flpPeopleBills";
            this.flpPeopleBills.Size = new System.Drawing.Size(1596, 630);
            this.flpPeopleBills.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.peopleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1604, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.systemPasswordToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountsToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // manageAccountsToolStripMenuItem
            // 
            this.manageAccountsToolStripMenuItem.Name = "manageAccountsToolStripMenuItem";
            this.manageAccountsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manageAccountsToolStripMenuItem.Text = "Manage Accounts";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePeopleToolStripMenuItem});
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.peopleToolStripMenuItem.Text = "People";
            // 
            // managePeopleToolStripMenuItem
            // 
            this.managePeopleToolStripMenuItem.Name = "managePeopleToolStripMenuItem";
            this.managePeopleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.managePeopleToolStripMenuItem.Text = "Manage People";
            // 
            // systemPasswordToolStripMenuItem
            // 
            this.systemPasswordToolStripMenuItem.Name = "systemPasswordToolStripMenuItem";
            this.systemPasswordToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.systemPasswordToolStripMenuItem.Text = "System Password";
            this.systemPasswordToolStripMenuItem.Click += new System.EventHandler(this.systemPasswordToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 961);
            this.Controls.Add(this.flpPeopleBills);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.chartBudget);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.tbBudgetTotal);
            this.Controls.Add(this.btnAddBudget);
            this.Controls.Add(this.flpBudget);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Bill Pay (and Budget)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flpBudget;
        private System.Windows.Forms.Button btnAddBudget;
        private System.Windows.Forms.TextBox tbBudgetTotal;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudget;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.FlowLayoutPanel flpPeopleBills;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemPasswordToolStripMenuItem;
    }
}

