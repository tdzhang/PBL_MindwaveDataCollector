namespace ThinkGearNETTest
{
    partial class RealDataView
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartReal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelConstant1 = new System.Windows.Forms.Label();
            this.labelConstant2 = new System.Windows.Forms.Label();
            this.btnRelax = new System.Windows.Forms.Button();
            this.btnEngagement = new System.Windows.Forms.Button();
            this.lableConstant3 = new System.Windows.Forms.Label();
            this.btnProductivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartReal)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReal
            // 
            this.chartReal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.Interval = 5D;
            chartArea1.AxisX.Maximum = 30D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.Maximum = 102D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartAreaRealData";
            this.chartReal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReal.Legends.Add(legend1);
            this.chartReal.Location = new System.Drawing.Point(34, 28);
            this.chartReal.Name = "chartReal";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartAreaRealData";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Attention";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartAreaRealData";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series2.Name = "Meditation";
            this.chartReal.Series.Add(series1);
            this.chartReal.Series.Add(series2);
            this.chartReal.Size = new System.Drawing.Size(428, 357);
            this.chartReal.TabIndex = 0;
            this.chartReal.Text = "chart1";
            // 
            // labelConstant1
            // 
            this.labelConstant1.AutoSize = true;
            this.labelConstant1.Location = new System.Drawing.Point(480, 28);
            this.labelConstant1.Name = "labelConstant1";
            this.labelConstant1.Size = new System.Drawing.Size(66, 13);
            this.labelConstant1.TabIndex = 1;
            this.labelConstant1.Text = "Relax Level:";
            // 
            // labelConstant2
            // 
            this.labelConstant2.AutoSize = true;
            this.labelConstant2.Location = new System.Drawing.Point(480, 101);
            this.labelConstant2.Name = "labelConstant2";
            this.labelConstant2.Size = new System.Drawing.Size(99, 13);
            this.labelConstant2.TabIndex = 2;
            this.labelConstant2.Text = "Engagement Level:";
            // 
            // btnRelax
            // 
            this.btnRelax.Enabled = false;
            this.btnRelax.Location = new System.Drawing.Point(503, 44);
            this.btnRelax.Name = "btnRelax";
            this.btnRelax.Size = new System.Drawing.Size(63, 38);
            this.btnRelax.TabIndex = 3;
            this.btnRelax.UseVisualStyleBackColor = true;
            // 
            // btnEngagement
            // 
            this.btnEngagement.Enabled = false;
            this.btnEngagement.Location = new System.Drawing.Point(503, 131);
            this.btnEngagement.Name = "btnEngagement";
            this.btnEngagement.Size = new System.Drawing.Size(63, 38);
            this.btnEngagement.TabIndex = 4;
            this.btnEngagement.UseVisualStyleBackColor = true;
            // 
            // lableConstant3
            // 
            this.lableConstant3.AutoSize = true;
            this.lableConstant3.Location = new System.Drawing.Point(480, 192);
            this.lableConstant3.Name = "lableConstant3";
            this.lableConstant3.Size = new System.Drawing.Size(91, 13);
            this.lableConstant3.TabIndex = 5;
            this.lableConstant3.Text = "Productivity Level";
            // 
            // btnProductivity
            // 
            this.btnProductivity.Enabled = false;
            this.btnProductivity.Location = new System.Drawing.Point(503, 218);
            this.btnProductivity.Name = "btnProductivity";
            this.btnProductivity.Size = new System.Drawing.Size(63, 38);
            this.btnProductivity.TabIndex = 6;
            this.btnProductivity.UseVisualStyleBackColor = true;
            // 
            // RealDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 447);
            this.ControlBox = false;
            this.Controls.Add(this.btnProductivity);
            this.Controls.Add(this.lableConstant3);
            this.Controls.Add(this.btnEngagement);
            this.Controls.Add(this.btnRelax);
            this.Controls.Add(this.labelConstant2);
            this.Controls.Add(this.labelConstant1);
            this.Controls.Add(this.chartReal);
            this.Name = "RealDataView";
            this.Text = "Real Data Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormView_FormClosing);
            this.Load += new System.EventHandler(this.FormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartReal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReal;
        private System.Windows.Forms.Label labelConstant1;
        private System.Windows.Forms.Label labelConstant2;
        private System.Windows.Forms.Button btnRelax;
        private System.Windows.Forms.Button btnEngagement;
        private System.Windows.Forms.Label lableConstant3;
        private System.Windows.Forms.Button btnProductivity;
    }
}