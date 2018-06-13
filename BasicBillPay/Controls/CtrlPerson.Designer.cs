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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.chartAccount1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbTotalIncome = new System.Windows.Forms.TextBox();
            this.tbTotalBillBudgetAccount1 = new System.Windows.Forms.TextBox();
            this.tbSplitTotal = new System.Windows.Forms.TextBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.tbTotalBills = new System.Windows.Forms.TextBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cctbTotalIncome = new BasicBillPay.Controls.CtrlCurrencyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pTopHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartAccount1
            // 
            this.chartAccount1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartAccount1.ChartAreas.Add(chartArea1);
            this.chartAccount1.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartAccount1.Legends.Add(legend1);
            this.chartAccount1.Location = new System.Drawing.Point(1000, 0);
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
            this.chartAccount1.Size = new System.Drawing.Size(300, 106);
            this.chartAccount1.TabIndex = 27;
            this.chartAccount1.Text = "chart1";
            // 
            // tbTotalIncome
            // 
            this.tbTotalIncome.Location = new System.Drawing.Point(595, 35);
            this.tbTotalIncome.Name = "tbTotalIncome";
            this.tbTotalIncome.Size = new System.Drawing.Size(72, 20);
            this.tbTotalIncome.TabIndex = 26;
            this.tbTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalBillBudgetAccount1
            // 
            this.tbTotalBillBudgetAccount1.Location = new System.Drawing.Point(833, 34);
            this.tbTotalBillBudgetAccount1.Name = "tbTotalBillBudgetAccount1";
            this.tbTotalBillBudgetAccount1.Size = new System.Drawing.Size(72, 20);
            this.tbTotalBillBudgetAccount1.TabIndex = 25;
            this.tbTotalBillBudgetAccount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSplitTotal
            // 
            this.tbSplitTotal.Location = new System.Drawing.Point(751, 34);
            this.tbSplitTotal.Name = "tbSplitTotal";
            this.tbSplitTotal.Size = new System.Drawing.Size(72, 20);
            this.tbSplitTotal.TabIndex = 24;
            this.tbSplitTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccount1
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(8, 2);
            this.lblPerson.Name = "lblAccount1";
            this.lblPerson.Size = new System.Drawing.Size(64, 13);
            this.lblPerson.TabIndex = 23;
            this.lblPerson.Text = "M Checking";
            // 
            // tbTotalBills
            // 
            this.tbTotalBills.Location = new System.Drawing.Point(673, 34);
            this.tbTotalBills.Name = "tbTotalBills";
            this.tbTotalBills.Size = new System.Drawing.Size(72, 20);
            this.tbTotalBills.TabIndex = 22;
            this.tbTotalBills.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddBill.ContextMenuStrip = this.contextMenuStrip1;
            this.btnAddBill.Location = new System.Drawing.Point(11, 28);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(89, 31);
            this.btnAddBill.TabIndex = 21;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransferToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // addTransferToolStripMenuItem
            // 
            this.addTransferToolStripMenuItem.Name = "addTransferToolStripMenuItem";
            this.addTransferToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addTransferToolStripMenuItem.Text = "Add Transfer";
            this.addTransferToolStripMenuItem.Click += new System.EventHandler(this.addTransferToolStripMenuItem_Click);
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
            this.flpBills.MinimumSize = new System.Drawing.Size(1000, 46);
            this.flpBills.Name = "flpBills";
            this.flpBills.Size = new System.Drawing.Size(1000, 46);
            this.flpBills.TabIndex = 20;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(596, 18);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(69, 13);
            this.lblTotalIncome.TabIndex = 28;
            this.lblTotalIncome.Text = "Total Income";
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(485, 34);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 30;
            this.cbPaidFrequency.SelectedIndexChanged += new System.EventHandler(this.cbPaidFrequency_SelectedIndexChanged);
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Location = new System.Drawing.Point(487, 16);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(63, 13);
            this.lblTimePeriod.TabIndex = 31;
            this.lblTimePeriod.Text = "Time Period";
            // 
            // lblTotalBills
            // 
            this.lblTotalBills.AutoSize = true;
            this.lblTotalBills.Location = new System.Drawing.Point(675, 19);
            this.lblTotalBills.Name = "lblTotalBills";
            this.lblTotalBills.Size = new System.Drawing.Size(52, 13);
            this.lblTotalBills.TabIndex = 32;
            this.lblTotalBills.Text = "Bills Total";
            // 
            // lblBudgetTotal
            // 
            this.lblBudgetTotal.AutoSize = true;
            this.lblBudgetTotal.Location = new System.Drawing.Point(754, 19);
            this.lblBudgetTotal.Name = "lblBudgetTotal";
            this.lblBudgetTotal.Size = new System.Drawing.Size(68, 13);
            this.lblBudgetTotal.TabIndex = 33;
            this.lblBudgetTotal.Text = "Budget Total";
            // 
            // lblExpenseTotal
            // 
            this.lblExpenseTotal.AutoSize = true;
            this.lblExpenseTotal.Location = new System.Drawing.Point(837, 19);
            this.lblExpenseTotal.Name = "lblExpenseTotal";
            this.lblExpenseTotal.Size = new System.Drawing.Size(75, 13);
            this.lblExpenseTotal.TabIndex = 34;
            this.lblExpenseTotal.Text = "Expense Total";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(917, 17);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(61, 13);
            this.lblSavings.TabIndex = 36;
            this.lblSavings.Text = "What\'s Left";
            // 
            // tbSavings
            // 
            this.tbSavings.Location = new System.Drawing.Point(916, 34);
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
            this.pTopHeader.Controls.Add(this.cctbTotalIncome);
            this.pTopHeader.Controls.Add(this.tbSavings);
            this.pTopHeader.Controls.Add(this.btnPayCheck);
            this.pTopHeader.Controls.Add(this.btnAddBill);
            this.pTopHeader.Controls.Add(this.lblSavings);
            this.pTopHeader.Controls.Add(this.tbTotalBills);
            this.pTopHeader.Controls.Add(this.lblPerson);
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
            // cctbTotalIncome
            // 
            this.cctbTotalIncome.Location = new System.Drawing.Point(384, 34);
            this.cctbTotalIncome.Margin = new System.Windows.Forms.Padding(0);
            this.cctbTotalIncome.Name = "cctbTotalIncome";
            this.cctbTotalIncome.Size = new System.Drawing.Size(66, 20);
            this.cctbTotalIncome.TabIndex = 38;
            this.cctbTotalIncome.Value = 0F;
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
            this.MinimumSize = new System.Drawing.Size(1300, 108);
            this.Name = "CtrlPerson";
            this.Size = new System.Drawing.Size(1300, 106);
            this.Load += new System.EventHandler(this.CtrlPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAccount1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblPerson;
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
        private CtrlCurrencyTextBox cctbTotalIncome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTransferToolStripMenuItem;
    }
}
