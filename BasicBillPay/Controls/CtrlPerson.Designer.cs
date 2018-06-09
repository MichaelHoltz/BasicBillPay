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
            this.tbTotalIncome = new System.Windows.Forms.TextBox();
            this.tbTotalBillBudgetAccount1 = new System.Windows.Forms.TextBox();
            this.tbSplitTotal = new System.Windows.Forms.TextBox();
            this.lblAccount1 = new System.Windows.Forms.Label();
            this.tbTotalBills = new System.Windows.Forms.TextBox();
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
            this.btnPayCheck = new System.Windows.Forms.Button();
            this.pTopHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).BeginInit();
            this.pTopHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartAccount1
            // 
            this.chartAccount1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartAccount1.ChartAreas.Add(chartArea2);
            this.chartAccount1.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartAccount1.Legends.Add(legend2);
            this.chartAccount1.Location = new System.Drawing.Point(1000, 0);
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
            this.chartAccount1.Size = new System.Drawing.Size(300, 260);
            this.chartAccount1.TabIndex = 27;
            this.chartAccount1.Text = "chart1";
            // 
            // tbTotalIncome
            // 
            this.tbTotalIncome.Location = new System.Drawing.Point(338, 35);
            this.tbTotalIncome.Name = "tbTotalIncome";
            this.tbTotalIncome.Size = new System.Drawing.Size(72, 20);
            this.tbTotalIncome.TabIndex = 26;
            this.tbTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalBillBudgetAccount1
            // 
            this.tbTotalBillBudgetAccount1.Location = new System.Drawing.Point(576, 34);
            this.tbTotalBillBudgetAccount1.Name = "tbTotalBillBudgetAccount1";
            this.tbTotalBillBudgetAccount1.Size = new System.Drawing.Size(72, 20);
            this.tbTotalBillBudgetAccount1.TabIndex = 25;
            this.tbTotalBillBudgetAccount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSplitTotal
            // 
            this.tbSplitTotal.Location = new System.Drawing.Point(494, 34);
            this.tbSplitTotal.Name = "tbSplitTotal";
            this.tbSplitTotal.Size = new System.Drawing.Size(72, 20);
            this.tbSplitTotal.TabIndex = 24;
            this.tbSplitTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSplitTotal.TextChanged += new System.EventHandler(this.tbSplitTotal_TextChanged);
            // 
            // lblAccount1
            // 
            this.lblAccount1.AutoSize = true;
            this.lblAccount1.Location = new System.Drawing.Point(8, 2);
            this.lblAccount1.Name = "lblAccount1";
            this.lblAccount1.Size = new System.Drawing.Size(64, 13);
            this.lblAccount1.TabIndex = 23;
            this.lblAccount1.Text = "M Checking";
            // 
            // tbTotalBills
            // 
            this.tbTotalBills.Location = new System.Drawing.Point(416, 34);
            this.tbTotalBills.Name = "tbTotalBills";
            this.tbTotalBills.Size = new System.Drawing.Size(72, 20);
            this.tbTotalBills.TabIndex = 22;
            this.tbTotalBills.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddBill.Location = new System.Drawing.Point(11, 28);
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
            this.flpBills.AutoSize = true;
            this.flpBills.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBills.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBills.Location = new System.Drawing.Point(0, 60);
            this.flpBills.MaximumSize = new System.Drawing.Size(1040, 600);
            this.flpBills.MinimumSize = new System.Drawing.Size(1000, 200);
            this.flpBills.Name = "flpBills";
            this.flpBills.Size = new System.Drawing.Size(1000, 200);
            this.flpBills.TabIndex = 20;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(339, 18);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(69, 13);
            this.lblTotalIncome.TabIndex = 28;
            this.lblTotalIncome.Text = "Total Income";
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(228, 34);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 30;
            this.cbPaidFrequency.SelectedIndexChanged += new System.EventHandler(this.cbPaidFrequency_SelectedIndexChanged);
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Location = new System.Drawing.Point(230, 16);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(63, 13);
            this.lblTimePeriod.TabIndex = 31;
            this.lblTimePeriod.Text = "Time Period";
            // 
            // lblTotalBills
            // 
            this.lblTotalBills.AutoSize = true;
            this.lblTotalBills.Location = new System.Drawing.Point(418, 19);
            this.lblTotalBills.Name = "lblTotalBills";
            this.lblTotalBills.Size = new System.Drawing.Size(52, 13);
            this.lblTotalBills.TabIndex = 32;
            this.lblTotalBills.Text = "Bills Total";
            // 
            // lblBudgetTotal
            // 
            this.lblBudgetTotal.AutoSize = true;
            this.lblBudgetTotal.Location = new System.Drawing.Point(497, 19);
            this.lblBudgetTotal.Name = "lblBudgetTotal";
            this.lblBudgetTotal.Size = new System.Drawing.Size(68, 13);
            this.lblBudgetTotal.TabIndex = 33;
            this.lblBudgetTotal.Text = "Budget Total";
            // 
            // lblExpenseTotal
            // 
            this.lblExpenseTotal.AutoSize = true;
            this.lblExpenseTotal.Location = new System.Drawing.Point(580, 19);
            this.lblExpenseTotal.Name = "lblExpenseTotal";
            this.lblExpenseTotal.Size = new System.Drawing.Size(75, 13);
            this.lblExpenseTotal.TabIndex = 34;
            this.lblExpenseTotal.Text = "Expense Total";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(660, 17);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(61, 13);
            this.lblSavings.TabIndex = 36;
            this.lblSavings.Text = "What\'s Left";
            // 
            // tbSavings
            // 
            this.tbSavings.Location = new System.Drawing.Point(659, 34);
            this.tbSavings.Name = "tbSavings";
            this.tbSavings.Size = new System.Drawing.Size(72, 20);
            this.tbSavings.TabIndex = 35;
            this.tbSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPayCheck
            // 
            this.btnPayCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPayCheck.Location = new System.Drawing.Point(106, 28);
            this.btnPayCheck.Name = "btnPayCheck";
            this.btnPayCheck.Size = new System.Drawing.Size(89, 31);
            this.btnPayCheck.TabIndex = 37;
            this.btnPayCheck.Text = "Paycheck";
            this.btnPayCheck.UseVisualStyleBackColor = false;
            this.btnPayCheck.Click += new System.EventHandler(this.btnPayCheck_Click);
            // 
            // pTopHeader
            // 
            this.pTopHeader.Controls.Add(this.tbSavings);
            this.pTopHeader.Controls.Add(this.btnPayCheck);
            this.pTopHeader.Controls.Add(this.btnAddBill);
            this.pTopHeader.Controls.Add(this.lblSavings);
            this.pTopHeader.Controls.Add(this.tbTotalBills);
            this.pTopHeader.Controls.Add(this.lblAccount1);
            this.pTopHeader.Controls.Add(this.lblExpenseTotal);
            this.pTopHeader.Controls.Add(this.tbSplitTotal);
            this.pTopHeader.Controls.Add(this.lblBudgetTotal);
            this.pTopHeader.Controls.Add(this.tbTotalBillBudgetAccount1);
            this.pTopHeader.Controls.Add(this.lblTotalBills);
            this.pTopHeader.Controls.Add(this.tbTotalIncome);
            this.pTopHeader.Controls.Add(this.lblTimePeriod);
            this.pTopHeader.Controls.Add(this.lblTotalIncome);
            this.pTopHeader.Controls.Add(this.cbPaidFrequency);
            this.pTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pTopHeader.MaximumSize = new System.Drawing.Size(1040, 60);
            this.pTopHeader.MinimumSize = new System.Drawing.Size(1000, 60);
            this.pTopHeader.Name = "pTopHeader";
            this.pTopHeader.Size = new System.Drawing.Size(1000, 60);
            this.pTopHeader.TabIndex = 38;
            // 
            // CtrlPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flpBills);
            this.Controls.Add(this.pTopHeader);
            this.Controls.Add(this.chartAccount1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1300, 200);
            this.Name = "CtrlPerson";
            this.Size = new System.Drawing.Size(1300, 260);
            this.Load += new System.EventHandler(this.CtrlPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).EndInit();
            this.pTopHeader.ResumeLayout(false);
            this.pTopHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAccount1;
        private System.Windows.Forms.TextBox tbTotalIncome;
        private System.Windows.Forms.TextBox tbTotalBillBudgetAccount1;
        private System.Windows.Forms.TextBox tbSplitTotal;
        private System.Windows.Forms.Label lblAccount1;
        private System.Windows.Forms.TextBox tbTotalBills;
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
        private System.Windows.Forms.Button btnPayCheck;
        private System.Windows.Forms.Panel pTopHeader;
    }
}
