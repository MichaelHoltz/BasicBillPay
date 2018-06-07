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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.btnSave = new System.Windows.Forms.Button();
            this.flpBudget = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBudget = new System.Windows.Forms.Button();
            this.tbBudgetTotal = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPeople = new System.Windows.Forms.Button();
            this.flpPeopleBills = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 742);
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
            this.flpBudget.Location = new System.Drawing.Point(103, 701);
            this.flpBudget.Name = "flpBudget";
            this.flpBudget.Size = new System.Drawing.Size(1003, 239);
            this.flpBudget.TabIndex = 4;
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.Yellow;
            this.btnAddBudget.Location = new System.Drawing.Point(8, 701);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(89, 31);
            this.btnAddBudget.TabIndex = 5;
            this.btnAddBudget.Text = "Add Budget";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudget_Click);
            // 
            // tbBudgetTotal
            // 
            this.tbBudgetTotal.Location = new System.Drawing.Point(460, 675);
            this.tbBudgetTotal.Name = "tbBudgetTotal";
            this.tbBudgetTotal.Size = new System.Drawing.Size(72, 20);
            this.tbBudgetTotal.TabIndex = 8;
            this.tbBudgetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // chartBudget
            // 
            this.chartBudget.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartBudget.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartBudget.Legends.Add(legend1);
            this.chartBudget.Location = new System.Drawing.Point(1112, 701);
            this.chartBudget.Name = "chartBudget";
            this.chartBudget.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.IsValueShownAsLabel = true;
            dataPoint1.Label = "";
            dataPoint1.LabelFormat = "c0";
            dataPoint2.IsValueShownAsLabel = true;
            dataPoint2.LabelFormat = "c";
            dataPoint2.LegendText = "P1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chartBudget.Series.Add(series1);
            this.chartBudget.Size = new System.Drawing.Size(476, 239);
            this.chartBudget.TabIndex = 20;
            this.chartBudget.Text = "chart2";
            // 
            // btnPeople
            // 
            this.btnPeople.Location = new System.Drawing.Point(91, 3);
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
            this.flpPeopleBills.Location = new System.Drawing.Point(2, 39);
            this.flpPeopleBills.Name = "flpPeopleBills";
            this.flpPeopleBills.Size = new System.Drawing.Size(1596, 630);
            this.flpPeopleBills.TabIndex = 23;
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
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Bill Pay (and Budget)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).EndInit();
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
    }
}

