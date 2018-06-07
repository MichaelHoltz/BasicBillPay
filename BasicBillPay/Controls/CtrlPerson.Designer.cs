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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.chartAccount1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbIncome1 = new System.Windows.Forms.TextBox();
            this.tbTotalBillBudgetAccount1 = new System.Windows.Forms.TextBox();
            this.tbSplitTotal = new System.Windows.Forms.TextBox();
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartAccount1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartAccount1.Legends.Add(legend1);
            this.chartAccount1.Location = new System.Drawing.Point(1023, 40);
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
            this.chartAccount1.Size = new System.Drawing.Size(476, 254);
            this.chartAccount1.TabIndex = 27;
            this.chartAccount1.Text = "chart1";
            // 
            // tbIncome1
            // 
            this.tbIncome1.Location = new System.Drawing.Point(624, 41);
            this.tbIncome1.Name = "tbIncome1";
            this.tbIncome1.Size = new System.Drawing.Size(72, 20);
            this.tbIncome1.TabIndex = 26;
            this.tbIncome1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalBillBudgetAccount1
            // 
            this.tbTotalBillBudgetAccount1.Location = new System.Drawing.Point(862, 40);
            this.tbTotalBillBudgetAccount1.Name = "tbTotalBillBudgetAccount1";
            this.tbTotalBillBudgetAccount1.Size = new System.Drawing.Size(72, 20);
            this.tbTotalBillBudgetAccount1.TabIndex = 25;
            this.tbTotalBillBudgetAccount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSplitTotal
            // 
            this.tbSplitTotal.Location = new System.Drawing.Point(780, 40);
            this.tbSplitTotal.Name = "tbSplitTotal";
            this.tbSplitTotal.Size = new System.Drawing.Size(72, 20);
            this.tbSplitTotal.TabIndex = 24;
            this.tbSplitTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSplitTotal.TextChanged += new System.EventHandler(this.tbSplitTotal_TextChanged);
            // 
            // lblAccount1
            // 
            this.lblAccount1.AutoSize = true;
            this.lblAccount1.Location = new System.Drawing.Point(11, 9);
            this.lblAccount1.Name = "lblAccount1";
            this.lblAccount1.Size = new System.Drawing.Size(64, 13);
            this.lblAccount1.TabIndex = 23;
            this.lblAccount1.Text = "M Checking";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(702, 40);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(72, 20);
            this.tbTotal.TabIndex = 22;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddBill.Location = new System.Drawing.Point(14, 35);
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
            this.flpBills.Location = new System.Drawing.Point(14, 70);
            this.flpBills.Name = "flpBills";
            this.flpBills.Size = new System.Drawing.Size(1003, 224);
            this.flpBills.TabIndex = 20;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(625, 24);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(69, 13);
            this.lblTotalIncome.TabIndex = 28;
            this.lblTotalIncome.Text = "Total Income";
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(514, 40);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 30;
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Location = new System.Drawing.Point(516, 22);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(63, 13);
            this.lblTimePeriod.TabIndex = 31;
            this.lblTimePeriod.Text = "Time Period";
            // 
            // lblTotalBills
            // 
            this.lblTotalBills.AutoSize = true;
            this.lblTotalBills.Location = new System.Drawing.Point(704, 25);
            this.lblTotalBills.Name = "lblTotalBills";
            this.lblTotalBills.Size = new System.Drawing.Size(52, 13);
            this.lblTotalBills.TabIndex = 32;
            this.lblTotalBills.Text = "Bills Total";
            // 
            // lblBudgetTotal
            // 
            this.lblBudgetTotal.AutoSize = true;
            this.lblBudgetTotal.Location = new System.Drawing.Point(783, 25);
            this.lblBudgetTotal.Name = "lblBudgetTotal";
            this.lblBudgetTotal.Size = new System.Drawing.Size(68, 13);
            this.lblBudgetTotal.TabIndex = 33;
            this.lblBudgetTotal.Text = "Budget Total";
            // 
            // lblExpenseTotal
            // 
            this.lblExpenseTotal.AutoSize = true;
            this.lblExpenseTotal.Location = new System.Drawing.Point(866, 25);
            this.lblExpenseTotal.Name = "lblExpenseTotal";
            this.lblExpenseTotal.Size = new System.Drawing.Size(75, 13);
            this.lblExpenseTotal.TabIndex = 34;
            this.lblExpenseTotal.Text = "Expense Total";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(946, 23);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(51, 13);
            this.lblSavings.TabIndex = 36;
            this.lblSavings.Text = "Savings..";
            // 
            // tbSavings
            // 
            this.tbSavings.Location = new System.Drawing.Point(945, 40);
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
            this.Controls.Add(this.tbSplitTotal);
            this.Controls.Add(this.lblAccount1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.flpBills);
            this.DoubleBuffered = true;
            this.Name = "CtrlPerson";
            this.Size = new System.Drawing.Size(1520, 302);
            this.Load += new System.EventHandler(this.CtrlPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAccount1;
        private System.Windows.Forms.TextBox tbIncome1;
        private System.Windows.Forms.TextBox tbTotalBillBudgetAccount1;
        private System.Windows.Forms.TextBox tbSplitTotal;
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
