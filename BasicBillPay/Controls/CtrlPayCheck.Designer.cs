namespace BasicBillPay.Controls
{
    partial class CtrlPaycheck
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.lblIdValue = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.tbNetPay = new System.Windows.Forms.TextBox();
            this.lblTimePeriod = new System.Windows.Forms.Label();
            this.cbPaidFrequency = new System.Windows.Forms.ComboBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.tbGarnishment = new System.Windows.Forms.TextBox();
            this.lblGarnishmentCost = new System.Windows.Forms.Label();
            this.tbBenefitCost = new System.Windows.Forms.TextBox();
            this.lblBenifitCost = new System.Windows.Forms.Label();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.tbGrossPay = new System.Windows.Forms.TextBox();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.dtpPayDayStart = new System.Windows.Forms.DateTimePicker();
            this.chartPayCheck = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Location = new System.Drawing.Point(832, 260);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(19, 13);
            this.lblIdValue.TabIndex = 15;
            this.lblIdValue.Text = "00";
            this.lblIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(233, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(808, 260);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(6, 55);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(45, 13);
            this.lblNetPay.TabIndex = 16;
            this.lblNetPay.Text = "Net Pay";
            // 
            // tbNetPay
            // 
            this.tbNetPay.Location = new System.Drawing.Point(9, 71);
            this.tbNetPay.Name = "tbNetPay";
            this.tbNetPay.Size = new System.Drawing.Size(64, 20);
            this.tbNetPay.TabIndex = 2;
            this.tbNetPay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNetPay_KeyUp);
            this.tbNetPay.Leave += new System.EventHandler(this.tbNetPay_Leave);
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Location = new System.Drawing.Point(100, 53);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(260, 13);
            this.lblTimePeriod.TabIndex = 33;
            this.lblTimePeriod.Text = "How often you receive a paycheck and Last Pay Day";
            // 
            // cbPaidFrequency
            // 
            this.cbPaidFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaidFrequency.FormattingEnabled = true;
            this.cbPaidFrequency.Location = new System.Drawing.Point(98, 71);
            this.cbPaidFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.cbPaidFrequency.Name = "cbPaidFrequency";
            this.cbPaidFrequency.Size = new System.Drawing.Size(71, 21);
            this.cbPaidFrequency.TabIndex = 3;
            this.cbPaidFrequency.SelectedIndexChanged += new System.EventHandler(this.cbPaidFrequency_SelectedIndexChanged);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tbOther);
            this.gbDetails.Controls.Add(this.lblOther);
            this.gbDetails.Controls.Add(this.tbGarnishment);
            this.gbDetails.Controls.Add(this.lblGarnishmentCost);
            this.gbDetails.Controls.Add(this.tbBenefitCost);
            this.gbDetails.Controls.Add(this.lblBenifitCost);
            this.gbDetails.Controls.Add(this.tbTax);
            this.gbDetails.Controls.Add(this.lblTax);
            this.gbDetails.Controls.Add(this.tbGrossPay);
            this.gbDetails.Controls.Add(this.lblGrossPay);
            this.gbDetails.Location = new System.Drawing.Point(9, 112);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(350, 145);
            this.gbDetails.TabIndex = 34;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Paycheck  details";
            // 
            // tbOther
            // 
            this.tbOther.Location = new System.Drawing.Point(244, 91);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(64, 20);
            this.tbOther.TabIndex = 9;
            this.tbOther.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbOther_KeyUp);
            this.tbOther.Leave += new System.EventHandler(this.tbOther_Leave);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(241, 75);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(33, 13);
            this.lblOther.TabIndex = 26;
            this.lblOther.Text = "Other";
            // 
            // tbGarnishment
            // 
            this.tbGarnishment.Location = new System.Drawing.Point(169, 91);
            this.tbGarnishment.Name = "tbGarnishment";
            this.tbGarnishment.Size = new System.Drawing.Size(64, 20);
            this.tbGarnishment.TabIndex = 8;
            this.tbGarnishment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbGarnishment_KeyUp);
            this.tbGarnishment.Leave += new System.EventHandler(this.tbGarnishment_Leave);
            // 
            // lblGarnishmentCost
            // 
            this.lblGarnishmentCost.AutoSize = true;
            this.lblGarnishmentCost.Location = new System.Drawing.Point(166, 75);
            this.lblGarnishmentCost.Name = "lblGarnishmentCost";
            this.lblGarnishmentCost.Size = new System.Drawing.Size(66, 13);
            this.lblGarnishmentCost.TabIndex = 24;
            this.lblGarnishmentCost.Text = "Garnishment";
            // 
            // tbBenefitCost
            // 
            this.tbBenefitCost.Location = new System.Drawing.Point(90, 91);
            this.tbBenefitCost.Name = "tbBenefitCost";
            this.tbBenefitCost.Size = new System.Drawing.Size(64, 20);
            this.tbBenefitCost.TabIndex = 7;
            this.tbBenefitCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBenefitCost_KeyUp);
            this.tbBenefitCost.Leave += new System.EventHandler(this.tbBenefitCost_Leave);
            // 
            // lblBenifitCost
            // 
            this.lblBenifitCost.AutoSize = true;
            this.lblBenifitCost.Location = new System.Drawing.Point(87, 75);
            this.lblBenifitCost.Name = "lblBenifitCost";
            this.lblBenifitCost.Size = new System.Drawing.Size(64, 13);
            this.lblBenifitCost.TabIndex = 22;
            this.lblBenifitCost.Text = "Benefit Cost";
            // 
            // tbTax
            // 
            this.tbTax.Location = new System.Drawing.Point(10, 91);
            this.tbTax.Name = "tbTax";
            this.tbTax.Size = new System.Drawing.Size(64, 20);
            this.tbTax.TabIndex = 6;
            this.tbTax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTax_KeyUp);
            this.tbTax.Leave += new System.EventHandler(this.tbTax_Leave);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(7, 75);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 20;
            this.lblTax.Text = "Tax";
            // 
            // tbGrossPay
            // 
            this.tbGrossPay.Location = new System.Drawing.Point(6, 37);
            this.tbGrossPay.Name = "tbGrossPay";
            this.tbGrossPay.Size = new System.Drawing.Size(64, 20);
            this.tbGrossPay.TabIndex = 5;
            this.tbGrossPay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbGrossPay_KeyUp);
            this.tbGrossPay.Leave += new System.EventHandler(this.tbGrossPay_Leave);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(3, 21);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(55, 13);
            this.lblGrossPay.TabIndex = 18;
            this.lblGrossPay.Text = "Gross Pay";
            // 
            // dtpPayDayStart
            // 
            this.dtpPayDayStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayDayStart.Location = new System.Drawing.Point(253, 72);
            this.dtpPayDayStart.Name = "dtpPayDayStart";
            this.dtpPayDayStart.Size = new System.Drawing.Size(107, 20);
            this.dtpPayDayStart.TabIndex = 4;
            // 
            // chartPayCheck
            // 
            this.chartPayCheck.BackColor = System.Drawing.Color.Transparent;
            chartArea14.Area3DStyle.Enable3D = true;
            chartArea14.BackColor = System.Drawing.Color.Transparent;
            chartArea14.Name = "ChartArea1";
            this.chartPayCheck.ChartAreas.Add(chartArea14);
            legend14.BackColor = System.Drawing.Color.Transparent;
            legend14.Name = "Legend1";
            this.chartPayCheck.Legends.Add(legend14);
            this.chartPayCheck.Location = new System.Drawing.Point(375, 3);
            this.chartPayCheck.Name = "chartPayCheck";
            this.chartPayCheck.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            dataPoint27.IsValueShownAsLabel = true;
            dataPoint27.Label = "";
            dataPoint27.LabelFormat = "c0";
            dataPoint28.IsValueShownAsLabel = true;
            dataPoint28.LabelFormat = "c";
            dataPoint28.LegendText = "P1";
            series14.Points.Add(dataPoint27);
            series14.Points.Add(dataPoint28);
            this.chartPayCheck.Series.Add(series14);
            this.chartPayCheck.Size = new System.Drawing.Size(476, 254);
            this.chartPayCheck.TabIndex = 36;
            this.chartPayCheck.Text = "chart1";
            // 
            // CtrlPaycheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartPayCheck);
            this.Controls.Add(this.dtpPayDayStart);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblTimePeriod);
            this.Controls.Add(this.cbPaidFrequency);
            this.Controls.Add(this.tbNetPay);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "CtrlPaycheck";
            this.Size = new System.Drawing.Size(866, 282);
            this.Load += new System.EventHandler(this.ControlPaycheck_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox tbNetPay;
        private System.Windows.Forms.Label lblTimePeriod;
        private System.Windows.Forms.ComboBox cbPaidFrequency;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox tbGrossPay;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.TextBox tbBenefitCost;
        private System.Windows.Forms.Label lblBenifitCost;
        private System.Windows.Forms.TextBox tbGarnishment;
        private System.Windows.Forms.Label lblGarnishmentCost;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.DateTimePicker dtpPayDayStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPayCheck;
    }
}
