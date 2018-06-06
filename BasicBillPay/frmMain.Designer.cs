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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.tbSplit1Total = new System.Windows.Forms.TextBox();
            this.tbSplit2Total = new System.Windows.Forms.TextBox();
            this.tbIncome2 = new System.Windows.Forms.TextBox();
            this.flpBills2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbTotalBillBudgetAccount1 = new System.Windows.Forms.TextBox();
            this.tbTotalBillBudgetAccount2 = new System.Windows.Forms.TextBox();
            this.tbIncome1 = new System.Windows.Forms.TextBox();
            this.chartAccount1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAccount2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPeople = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount2)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBills
            // 
            this.flpBills.AllowDrop = true;
            this.flpBills.AutoScroll = true;
            this.flpBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBills.Location = new System.Drawing.Point(103, 78);
            this.flpBills.Name = "flpBills";
            this.flpBills.Size = new System.Drawing.Size(1003, 183);
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
            this.flpBudget.Location = new System.Drawing.Point(103, 551);
            this.flpBudget.Name = "flpBudget";
            this.flpBudget.Size = new System.Drawing.Size(1003, 239);
            this.flpBudget.TabIndex = 4;
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.Yellow;
            this.btnAddBudget.Location = new System.Drawing.Point(8, 551);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(89, 31);
            this.btnAddBudget.TabIndex = 5;
            this.btnAddBudget.Text = "Add Budget";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudget_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(882, 52);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(72, 20);
            this.tbTotal.TabIndex = 6;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotal2
            // 
            this.tbTotal2.Location = new System.Drawing.Point(882, 263);
            this.tbTotal2.Name = "tbTotal2";
            this.tbTotal2.Size = new System.Drawing.Size(72, 20);
            this.tbTotal2.TabIndex = 7;
            this.tbTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbBudgetTotal
            // 
            this.tbBudgetTotal.Location = new System.Drawing.Point(460, 525);
            this.tbBudgetTotal.Name = "tbBudgetTotal";
            this.tbBudgetTotal.Size = new System.Drawing.Size(72, 20);
            this.tbBudgetTotal.TabIndex = 8;
            this.tbBudgetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccount1
            // 
            this.lblAccount1.AutoSize = true;
            this.lblAccount1.Location = new System.Drawing.Point(805, 55);
            this.lblAccount1.Name = "lblAccount1";
            this.lblAccount1.Size = new System.Drawing.Size(64, 13);
            this.lblAccount1.TabIndex = 9;
            this.lblAccount1.Text = "M Checking";
            // 
            // lblAccount2
            // 
            this.lblAccount2.AutoSize = true;
            this.lblAccount2.Location = new System.Drawing.Point(805, 266);
            this.lblAccount2.Name = "lblAccount2";
            this.lblAccount2.Size = new System.Drawing.Size(62, 13);
            this.lblAccount2.TabIndex = 10;
            this.lblAccount2.Text = "C Checking";
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
            // tbSplit1Total
            // 
            this.tbSplit1Total.Location = new System.Drawing.Point(960, 263);
            this.tbSplit1Total.Name = "tbSplit1Total";
            this.tbSplit1Total.Size = new System.Drawing.Size(72, 20);
            this.tbSplit1Total.TabIndex = 13;
            this.tbSplit1Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSplit1Total.TextChanged += new System.EventHandler(this.tbSplit1Total_TextChanged);
            // 
            // tbSplit2Total
            // 
            this.tbSplit2Total.Location = new System.Drawing.Point(960, 52);
            this.tbSplit2Total.Name = "tbSplit2Total";
            this.tbSplit2Total.Size = new System.Drawing.Size(72, 20);
            this.tbSplit2Total.TabIndex = 14;
            this.tbSplit2Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSplit2Total.TextChanged += new System.EventHandler(this.tbSplit2Total_TextChanged);
            // 
            // tbIncome2
            // 
            this.tbIncome2.Location = new System.Drawing.Point(713, 263);
            this.tbIncome2.Name = "tbIncome2";
            this.tbIncome2.Size = new System.Drawing.Size(72, 20);
            this.tbIncome2.TabIndex = 15;
            this.tbIncome2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flpBills2
            // 
            this.flpBills2.AllowDrop = true;
            this.flpBills2.AutoScroll = true;
            this.flpBills2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBills2.Location = new System.Drawing.Point(103, 286);
            this.flpBills2.Name = "flpBills2";
            this.flpBills2.Size = new System.Drawing.Size(1003, 183);
            this.flpBills2.TabIndex = 2;
            // 
            // tbTotalBillBudgetAccount1
            // 
            this.tbTotalBillBudgetAccount1.Location = new System.Drawing.Point(1038, 52);
            this.tbTotalBillBudgetAccount1.Name = "tbTotalBillBudgetAccount1";
            this.tbTotalBillBudgetAccount1.Size = new System.Drawing.Size(72, 20);
            this.tbTotalBillBudgetAccount1.TabIndex = 17;
            this.tbTotalBillBudgetAccount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalBillBudgetAccount2
            // 
            this.tbTotalBillBudgetAccount2.Location = new System.Drawing.Point(1038, 263);
            this.tbTotalBillBudgetAccount2.Name = "tbTotalBillBudgetAccount2";
            this.tbTotalBillBudgetAccount2.Size = new System.Drawing.Size(72, 20);
            this.tbTotalBillBudgetAccount2.TabIndex = 17;
            this.tbTotalBillBudgetAccount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbIncome1
            // 
            this.tbIncome1.Location = new System.Drawing.Point(713, 52);
            this.tbIncome1.Name = "tbIncome1";
            this.tbIncome1.Size = new System.Drawing.Size(72, 20);
            this.tbIncome1.TabIndex = 18;
            this.tbIncome1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chartAccount1
            // 
            this.chartAccount1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartAccount1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartAccount1.Legends.Add(legend1);
            this.chartAccount1.Location = new System.Drawing.Point(1112, 78);
            this.chartAccount1.Name = "chartAccount1";
            this.chartAccount1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
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
            this.chartAccount1.Series.Add(series1);
            this.chartAccount1.Size = new System.Drawing.Size(476, 183);
            this.chartAccount1.TabIndex = 19;
            this.chartAccount1.Text = "chart1";
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
            this.chartBudget.Location = new System.Drawing.Point(1112, 551);
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
            // chartAccount2
            // 
            this.chartAccount2.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartAccount2.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.chartAccount2.Legends.Add(legend3);
            this.chartAccount2.Location = new System.Drawing.Point(1112, 286);
            this.chartAccount2.Name = "chartAccount2";
            this.chartAccount2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            dataPoint5.IsValueShownAsLabel = true;
            dataPoint5.Label = "";
            dataPoint5.LabelFormat = "c0";
            dataPoint6.IsValueShownAsLabel = true;
            dataPoint6.LabelFormat = "c";
            dataPoint6.LegendText = "P1";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            this.chartAccount2.Series.Add(series3);
            this.chartAccount2.Size = new System.Drawing.Size(476, 183);
            this.chartAccount2.TabIndex = 21;
            this.chartAccount2.Text = "chart3";
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 950);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.chartAccount2);
            this.Controls.Add(this.chartBudget);
            this.Controls.Add(this.chartAccount1);
            this.Controls.Add(this.tbIncome1);
            this.Controls.Add(this.tbTotalBillBudgetAccount2);
            this.Controls.Add(this.tbTotalBillBudgetAccount1);
            this.Controls.Add(this.flpBills2);
            this.Controls.Add(this.tbIncome2);
            this.Controls.Add(this.tbSplit2Total);
            this.Controls.Add(this.tbSplit1Total);
            this.Controls.Add(this.btnSettings);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount2)).EndInit();
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
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox tbSplit1Total;
        private System.Windows.Forms.TextBox tbSplit2Total;
        private System.Windows.Forms.TextBox tbIncome2;
        private System.Windows.Forms.FlowLayoutPanel flpBills2;
        private System.Windows.Forms.TextBox tbTotalBillBudgetAccount1;
        private System.Windows.Forms.TextBox tbTotalBillBudgetAccount2;
        private System.Windows.Forms.TextBox tbIncome1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAccount1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudget;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAccount2;
        private System.Windows.Forms.Button btnPeople;
    }
}

