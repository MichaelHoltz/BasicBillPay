namespace BasicBillPay.Controls
{
    partial class CtrlBudget
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBudget = new System.Windows.Forms.Label();
            this.btnAddBudget = new System.Windows.Forms.Button();
            this.flpBudget = new System.Windows.Forms.FlowLayoutPanel();
            this.cbPayFrequency = new System.Windows.Forms.ComboBox();
            this.lblTimePeriod = new System.Windows.Forms.Label();
            this.lblBudgetTotal = new System.Windows.Forms.Label();
            this.pTopHeader = new System.Windows.Forms.Panel();
            this.cctbBudgetTotal = new BasicBillPay.Controls.CtrlCurrencyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).BeginInit();
            this.pTopHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartBudget
            // 
            this.chartBudget.BackColor = System.Drawing.Color.Silver;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartBudget.ChartAreas.Add(chartArea2);
            this.chartBudget.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartBudget.Legends.Add(legend2);
            this.chartBudget.Location = new System.Drawing.Point(1000, 0);
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
            this.chartBudget.Size = new System.Drawing.Size(300, 106);
            this.chartBudget.TabIndex = 27;
            this.chartBudget.Text = "chart1";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(8, 2);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(69, 13);
            this.lblBudget.TabIndex = 23;
            this.lblBudget.Text = "Budget Items";
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddBudget.Location = new System.Drawing.Point(11, 28);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(105, 31);
            this.btnAddBudget.TabIndex = 21;
            this.btnAddBudget.Text = "Add Budget Item";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudgetItem_Click);
            // 
            // flpBudget
            // 
            this.flpBudget.AllowDrop = true;
            this.flpBudget.AutoScroll = true;
            this.flpBudget.AutoSize = true;
            this.flpBudget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBudget.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBudget.Location = new System.Drawing.Point(0, 60);
            this.flpBudget.MaximumSize = new System.Drawing.Size(1040, 600);
            this.flpBudget.MinimumSize = new System.Drawing.Size(1000, 46);
            this.flpBudget.Name = "flpBudget";
            this.flpBudget.Size = new System.Drawing.Size(1000, 46);
            this.flpBudget.TabIndex = 20;
            // 
            // cbPayFrequency
            // 
            this.cbPayFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayFrequency.FormattingEnabled = true;
            this.cbPayFrequency.Location = new System.Drawing.Point(485, 34);
            this.cbPayFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPayFrequency.Name = "cbPayFrequency";
            this.cbPayFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPayFrequency.TabIndex = 30;
            this.cbPayFrequency.SelectedIndexChanged += new System.EventHandler(this.cbPayFrequency_SelectedIndexChanged);
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Location = new System.Drawing.Point(485, 18);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(63, 13);
            this.lblTimePeriod.TabIndex = 31;
            this.lblTimePeriod.Text = "Time Period";
            // 
            // lblBudgetTotal
            // 
            this.lblBudgetTotal.AutoSize = true;
            this.lblBudgetTotal.Location = new System.Drawing.Point(596, 18);
            this.lblBudgetTotal.Name = "lblBudgetTotal";
            this.lblBudgetTotal.Size = new System.Drawing.Size(68, 13);
            this.lblBudgetTotal.TabIndex = 33;
            this.lblBudgetTotal.Text = "Budget Total";
            // 
            // pTopHeader
            // 
            this.pTopHeader.Controls.Add(this.cctbBudgetTotal);
            this.pTopHeader.Controls.Add(this.btnAddBudget);
            this.pTopHeader.Controls.Add(this.lblBudget);
            this.pTopHeader.Controls.Add(this.lblBudgetTotal);
            this.pTopHeader.Controls.Add(this.lblTimePeriod);
            this.pTopHeader.Controls.Add(this.cbPayFrequency);
            this.pTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pTopHeader.MaximumSize = new System.Drawing.Size(1040, 60);
            this.pTopHeader.MinimumSize = new System.Drawing.Size(1000, 60);
            this.pTopHeader.Name = "pTopHeader";
            this.pTopHeader.Size = new System.Drawing.Size(1000, 60);
            this.pTopHeader.TabIndex = 38;
            // 
            // cctbBudgetTotal
            // 
            this.cctbBudgetTotal.Location = new System.Drawing.Point(595, 35);
            this.cctbBudgetTotal.Margin = new System.Windows.Forms.Padding(0);
            this.cctbBudgetTotal.Name = "cctbBudgetTotal";
            this.cctbBudgetTotal.Size = new System.Drawing.Size(66, 20);
            this.cctbBudgetTotal.TabIndex = 38;
            this.cctbBudgetTotal.Value = 0F;
            // 
            // CtrlBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flpBudget);
            this.Controls.Add(this.pTopHeader);
            this.Controls.Add(this.chartBudget);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1300, 108);
            this.Name = "CtrlBudget";
            this.Size = new System.Drawing.Size(1300, 106);
            this.Load += new System.EventHandler(this.CtrlBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).EndInit();
            this.pTopHeader.ResumeLayout(false);
            this.pTopHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudget;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Button btnAddBudget;
        private System.Windows.Forms.FlowLayoutPanel flpBudget;
        private System.Windows.Forms.ComboBox cbPayFrequency;
        private System.Windows.Forms.Label lblTimePeriod;
        private System.Windows.Forms.Label lblBudgetTotal;
        private System.Windows.Forms.Panel pTopHeader;
        private CtrlCurrencyTextBox cctbBudgetTotal;
    }
}
