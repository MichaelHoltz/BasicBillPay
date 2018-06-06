namespace BasicBillPay.Controls
{
    partial class CtrlPerson
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
            this.chartAccount1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbIncome1 = new System.Windows.Forms.TextBox();
            this.tbTotalBillBudgetAccount1 = new System.Windows.Forms.TextBox();
            this.tbSplit2Total = new System.Windows.Forms.TextBox();
            this.lblAccount1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.flpBills = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.cbPaidFrequency = new System.Windows.Forms.ComboBox();
            this.lblTimePeriod = new System.Windows.Forms.Label();
            this.lblTotalBills = new System.Windows.Forms.Label();
            this.lblBudgetTotal = new System.Windows.Forms.Label();
            this.lblExpenseTotal = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.tbSavings = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAccount1
            // 
            this.chartAccount1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartAccount1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartAccount1.Legends.Add(legend2);
            this.chartAccount1.Location = new System.Drawing.Point(1108, 40);
            this.chartAccount1.Name = "chartAccount1";
            this.chartAccount1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
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
            this.chartAccount1.Series.Add(series2);
            this.chartAccount1.Size = new System.Drawing.Size(476, 254);
            this.chartAccount1.TabIndex = 27;
            this.chartAccount1.Text = "chart1";
            // 
            // tbIncome1
            // 
            this.tbIncome1.Location = new System.Drawing.Point(709, 41);
            this.tbIncome1.Name = "tbIncome1";
            this.tbIncome1.Size = new System.Drawing.Size(72, 20);
            this.tbIncome1.TabIndex = 26;
            this.tbIncome1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalBillBudgetAccount1
            // 
            this.tbTotalBillBudgetAccount1.Location = new System.Drawing.Point(947, 40);
            this.tbTotalBillBudgetAccount1.Name = "tbTotalBillBudgetAccount1";
            this.tbTotalBillBudgetAccount1.Size = new System.Drawing.Size(72, 20);
            this.tbTotalBillBudgetAccount1.TabIndex = 25;
            this.tbTotalBillBudgetAccount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSplit2Total
            // 
            this.tbSplit2Total.Location = new System.Drawing.Point(865, 40);
            this.tbSplit2Total.Name = "tbSplit2Total";
            this.tbSplit2Total.Size = new System.Drawing.Size(72, 20);
            this.tbSplit2Total.TabIndex = 24;
            this.tbSplit2Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccount1
            // 
            this.lblAccount1.AutoSize = true;
            this.lblAccount1.Location = new System.Drawing.Point(17, 11);
            this.lblAccount1.Name = "lblAccount1";
            this.lblAccount1.Size = new System.Drawing.Size(64, 13);
            this.lblAccount1.TabIndex = 23;
            this.lblAccount1.Text = "M Checking";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(787, 40);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(72, 20);
            this.tbTotal.TabIndex = 22;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddBill.Location = new System.Drawing.Point(4, 70);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(89, 31);
            this.btnAddBill.TabIndex = 21;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // flpBills
            // 
            this.flpBills.AllowDrop = true;
            this.flpBills.AutoScroll = true;
            this.flpBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBills.Location = new System.Drawing.Point(99, 70);
            this.flpBills.Name = "flpBills";
            this.flpBills.Size = new System.Drawing.Size(1003, 224);
            this.flpBills.TabIndex = 20;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(710, 24);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(69, 13);
            this.lblTotalIncome.TabIndex = 28;
            this.lblTotalIncome.Text = "Total Income";
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(599, 40);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 30;
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Location = new System.Drawing.Point(601, 22);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(63, 13);
            this.lblTimePeriod.TabIndex = 31;
            this.lblTimePeriod.Text = "Time Period";
            // 
            // lblTotalBills
            // 
            this.lblTotalBills.AutoSize = true;
            this.lblTotalBills.Location = new System.Drawing.Point(789, 25);
            this.lblTotalBills.Name = "lblTotalBills";
            this.lblTotalBills.Size = new System.Drawing.Size(52, 13);
            this.lblTotalBills.TabIndex = 32;
            this.lblTotalBills.Text = "Bills Total";
            // 
            // lblBudgetTotal
            // 
            this.lblBudgetTotal.AutoSize = true;
            this.lblBudgetTotal.Location = new System.Drawing.Point(868, 25);
            this.lblBudgetTotal.Name = "lblBudgetTotal";
            this.lblBudgetTotal.Size = new System.Drawing.Size(68, 13);
            this.lblBudgetTotal.TabIndex = 33;
            this.lblBudgetTotal.Text = "Budget Total";
            // 
            // lblExpenseTotal
            // 
            this.lblExpenseTotal.AutoSize = true;
            this.lblExpenseTotal.Location = new System.Drawing.Point(951, 25);
            this.lblExpenseTotal.Name = "lblExpenseTotal";
            this.lblExpenseTotal.Size = new System.Drawing.Size(75, 13);
            this.lblExpenseTotal.TabIndex = 34;
            this.lblExpenseTotal.Text = "Expense Total";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(1031, 23);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(51, 13);
            this.lblSavings.TabIndex = 36;
            this.lblSavings.Text = "Savings..";
            // 
            // tbSavings
            // 
            this.tbSavings.Location = new System.Drawing.Point(1030, 40);
            this.tbSavings.Name = "tbSavings";
            this.tbSavings.Size = new System.Drawing.Size(72, 20);
            this.tbSavings.TabIndex = 35;
            this.tbSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CtrlPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.tbSavings);
            this.Controls.Add(this.lblExpenseTotal);
            this.Controls.Add(this.lblBudgetTotal);
            this.Controls.Add(this.lblTotalBills);
            this.Controls.Add(this.lblTimePeriod);
            this.Controls.Add(this.cbPaidFrequency);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.chartAccount1);
            this.Controls.Add(this.tbIncome1);
            this.Controls.Add(this.tbTotalBillBudgetAccount1);
            this.Controls.Add(this.tbSplit2Total);
            this.Controls.Add(this.lblAccount1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.flpBills);
            this.DoubleBuffered = true;
            this.Name = "CtrlPerson";
            this.Size = new System.Drawing.Size(1598, 302);
            this.Load += new System.EventHandler(this.CtrlPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAccount1;
        private System.Windows.Forms.TextBox tbIncome1;
        private System.Windows.Forms.TextBox tbTotalBillBudgetAccount1;
        private System.Windows.Forms.TextBox tbSplit2Total;
        private System.Windows.Forms.Label lblAccount1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.FlowLayoutPanel flpBills;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.ComboBox cbPaidFrequency;
        private System.Windows.Forms.Label lblTimePeriod;
        private System.Windows.Forms.Label lblTotalBills;
        private System.Windows.Forms.Label lblBudgetTotal;
        private System.Windows.Forms.Label lblExpenseTotal;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.TextBox tbSavings;
    }
}
