namespace ThinkGearNETTest
{
    partial class HistoryDataForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartHistory1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRealTime = new System.Windows.Forms.Button();
            this.butPauseResume = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnStaticData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.constantLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelConstant2 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.bntRight = new System.Windows.Forms.Button();
            this.chartHistory2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRealTime2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chartHistory3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRealTime3 = new System.Windows.Forms.Button();
            this.btnProductivity1 = new System.Windows.Forms.Button();
            this.lableConstant3 = new System.Windows.Forms.Label();
            this.btnEngagement1 = new System.Windows.Forms.Button();
            this.btnRelax1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelConstant1 = new System.Windows.Forms.Label();
            this.btnProductivity2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEngagement2 = new System.Windows.Forms.Button();
            this.btnRelax2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProductivity3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEngagement3 = new System.Windows.Forms.Button();
            this.btnRelax3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHistory1
            // 
            this.chartHistory1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
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
            this.chartHistory1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistory1.Legends.Add(legend1);
            this.chartHistory1.Location = new System.Drawing.Point(18, 122);
            this.chartHistory1.Name = "chartHistory1";
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
            this.chartHistory1.Series.Add(series1);
            this.chartHistory1.Series.Add(series2);
            this.chartHistory1.Size = new System.Drawing.Size(583, 151);
            this.chartHistory1.TabIndex = 1;
            this.chartHistory1.Text = "chart1";
            // 
            // btnRealTime
            // 
            this.btnRealTime.Location = new System.Drawing.Point(12, 12);
            this.btnRealTime.Name = "btnRealTime";
            this.btnRealTime.Size = new System.Drawing.Size(112, 23);
            this.btnRealTime.TabIndex = 3;
            this.btnRealTime.Text = "OpenFile1";
            this.btnRealTime.UseVisualStyleBackColor = true;
            this.btnRealTime.Click += new System.EventHandler(this.btnRealTime_Click);
            // 
            // butPauseResume
            // 
            this.butPauseResume.Location = new System.Drawing.Point(130, 12);
            this.butPauseResume.Name = "butPauseResume";
            this.butPauseResume.Size = new System.Drawing.Size(112, 23);
            this.butPauseResume.TabIndex = 4;
            this.butPauseResume.Text = "Pause/Resume";
            this.butPauseResume.UseVisualStyleBackColor = true;
            this.butPauseResume.Click += new System.EventHandler(this.butPauseResume_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnStaticData
            // 
            this.btnStaticData.Location = new System.Drawing.Point(329, 12);
            this.btnStaticData.Name = "btnStaticData";
            this.btnStaticData.Size = new System.Drawing.Size(75, 23);
            this.btnStaticData.TabIndex = 6;
            this.btnStaticData.Text = "Static Data";
            this.btnStaticData.UseVisualStyleBackColor = true;
            this.btnStaticData.Click += new System.EventHandler(this.btnStaticData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1000";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // constantLabel
            // 
            this.constantLabel.AutoSize = true;
            this.constantLabel.Location = new System.Drawing.Point(76, 70);
            this.constantLabel.Name = "constantLabel";
            this.constantLabel.Size = new System.Drawing.Size(20, 13);
            this.constantLabel.TabIndex = 8;
            this.constantLabel.Text = "ms";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(424, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelConstant2
            // 
            this.labelConstant2.AutoSize = true;
            this.labelConstant2.Location = new System.Drawing.Point(514, 17);
            this.labelConstant2.Name = "labelConstant2";
            this.labelConstant2.Size = new System.Drawing.Size(36, 13);
            this.labelConstant2.TabIndex = 10;
            this.labelConstant2.Text = "Points";
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(557, 11);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(29, 23);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // bntRight
            // 
            this.bntRight.Location = new System.Drawing.Point(586, 11);
            this.bntRight.Name = "bntRight";
            this.bntRight.Size = new System.Drawing.Size(31, 23);
            this.bntRight.TabIndex = 12;
            this.bntRight.Text = ">";
            this.bntRight.UseVisualStyleBackColor = true;
            this.bntRight.Click += new System.EventHandler(this.bntRight_Click);
            // 
            // chartHistory2
            // 
            this.chartHistory2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisX.Interval = 5D;
            chartArea2.AxisX.Maximum = 30D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.Maximum = 102D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartAreaRealData";
            this.chartHistory2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHistory2.Legends.Add(legend2);
            this.chartHistory2.Location = new System.Drawing.Point(18, 292);
            this.chartHistory2.Name = "chartHistory2";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartAreaRealData";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Green;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "Attention";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartAreaRealData";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series4.Name = "Meditation";
            this.chartHistory2.Series.Add(series3);
            this.chartHistory2.Series.Add(series4);
            this.chartHistory2.Size = new System.Drawing.Size(583, 151);
            this.chartHistory2.TabIndex = 13;
            this.chartHistory2.Text = "chart1";
            // 
            // btnRealTime2
            // 
            this.btnRealTime2.Location = new System.Drawing.Point(12, 41);
            this.btnRealTime2.Name = "btnRealTime2";
            this.btnRealTime2.Size = new System.Drawing.Size(112, 23);
            this.btnRealTime2.TabIndex = 14;
            this.btnRealTime2.Text = "OpenFile2";
            this.btnRealTime2.UseVisualStyleBackColor = true;
            this.btnRealTime2.Click += new System.EventHandler(this.btnRealTime2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartHistory3
            // 
            this.chartHistory3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisX.Interval = 5D;
            chartArea3.AxisX.Maximum = 30D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Interval = 10D;
            chartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.Maximum = 102D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartAreaRealData";
            this.chartHistory3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartHistory3.Legends.Add(legend3);
            this.chartHistory3.Location = new System.Drawing.Point(18, 462);
            this.chartHistory3.Name = "chartHistory3";
            series5.BorderWidth = 4;
            series5.ChartArea = "ChartAreaRealData";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series5.Name = "Attention";
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartAreaRealData";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series6.Legend = "Legend1";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series6.Name = "Meditation";
            this.chartHistory3.Series.Add(series5);
            this.chartHistory3.Series.Add(series6);
            this.chartHistory3.Size = new System.Drawing.Size(583, 188);
            this.chartHistory3.TabIndex = 16;
            this.chartHistory3.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // btnRealTime3
            // 
            this.btnRealTime3.Location = new System.Drawing.Point(130, 41);
            this.btnRealTime3.Name = "btnRealTime3";
            this.btnRealTime3.Size = new System.Drawing.Size(112, 23);
            this.btnRealTime3.TabIndex = 19;
            this.btnRealTime3.Text = "OpenFile3";
            this.btnRealTime3.UseVisualStyleBackColor = true;
            this.btnRealTime3.Click += new System.EventHandler(this.btnRealTime3_Click);
            // 
            // btnProductivity1
            // 
            this.btnProductivity1.Enabled = false;
            this.btnProductivity1.Location = new System.Drawing.Point(651, 239);
            this.btnProductivity1.Name = "btnProductivity1";
            this.btnProductivity1.Size = new System.Drawing.Size(52, 34);
            this.btnProductivity1.TabIndex = 25;
            this.btnProductivity1.UseVisualStyleBackColor = true;
            // 
            // lableConstant3
            // 
            this.lableConstant3.AutoSize = true;
            this.lableConstant3.Location = new System.Drawing.Point(628, 223);
            this.lableConstant3.Name = "lableConstant3";
            this.lableConstant3.Size = new System.Drawing.Size(91, 13);
            this.lableConstant3.TabIndex = 24;
            this.lableConstant3.Text = "Productivity Level";
            // 
            // btnEngagement1
            // 
            this.btnEngagement1.Enabled = false;
            this.btnEngagement1.Location = new System.Drawing.Point(651, 187);
            this.btnEngagement1.Name = "btnEngagement1";
            this.btnEngagement1.Size = new System.Drawing.Size(52, 33);
            this.btnEngagement1.TabIndex = 23;
            this.btnEngagement1.UseVisualStyleBackColor = true;
            // 
            // btnRelax1
            // 
            this.btnRelax1.Enabled = false;
            this.btnRelax1.Location = new System.Drawing.Point(651, 138);
            this.btnRelax1.Name = "btnRelax1";
            this.btnRelax1.Size = new System.Drawing.Size(52, 30);
            this.btnRelax1.TabIndex = 22;
            this.btnRelax1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Engagement Level:";
            // 
            // labelConstant1
            // 
            this.labelConstant1.AutoSize = true;
            this.labelConstant1.Location = new System.Drawing.Point(628, 122);
            this.labelConstant1.Name = "labelConstant1";
            this.labelConstant1.Size = new System.Drawing.Size(66, 13);
            this.labelConstant1.TabIndex = 20;
            this.labelConstant1.Text = "Relax Level:";
            // 
            // btnProductivity2
            // 
            this.btnProductivity2.Enabled = false;
            this.btnProductivity2.Location = new System.Drawing.Point(651, 409);
            this.btnProductivity2.Name = "btnProductivity2";
            this.btnProductivity2.Size = new System.Drawing.Size(52, 34);
            this.btnProductivity2.TabIndex = 31;
            this.btnProductivity2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Productivity Level";
            // 
            // btnEngagement2
            // 
            this.btnEngagement2.Enabled = false;
            this.btnEngagement2.Location = new System.Drawing.Point(651, 357);
            this.btnEngagement2.Name = "btnEngagement2";
            this.btnEngagement2.Size = new System.Drawing.Size(52, 33);
            this.btnEngagement2.TabIndex = 29;
            this.btnEngagement2.UseVisualStyleBackColor = true;
            // 
            // btnRelax2
            // 
            this.btnRelax2.Enabled = false;
            this.btnRelax2.Location = new System.Drawing.Point(651, 308);
            this.btnRelax2.Name = "btnRelax2";
            this.btnRelax2.Size = new System.Drawing.Size(52, 30);
            this.btnRelax2.TabIndex = 28;
            this.btnRelax2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Engagement Level:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Relax Level:";
            // 
            // btnProductivity3
            // 
            this.btnProductivity3.Enabled = false;
            this.btnProductivity3.Location = new System.Drawing.Point(651, 594);
            this.btnProductivity3.Name = "btnProductivity3";
            this.btnProductivity3.Size = new System.Drawing.Size(52, 34);
            this.btnProductivity3.TabIndex = 37;
            this.btnProductivity3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Productivity Level";
            // 
            // btnEngagement3
            // 
            this.btnEngagement3.Enabled = false;
            this.btnEngagement3.Location = new System.Drawing.Point(651, 542);
            this.btnEngagement3.Name = "btnEngagement3";
            this.btnEngagement3.Size = new System.Drawing.Size(52, 33);
            this.btnEngagement3.TabIndex = 35;
            this.btnEngagement3.UseVisualStyleBackColor = true;
            // 
            // btnRelax3
            // 
            this.btnRelax3.Enabled = false;
            this.btnRelax3.Location = new System.Drawing.Point(651, 493);
            this.btnRelax3.Name = "btnRelax3";
            this.btnRelax3.Size = new System.Drawing.Size(52, 30);
            this.btnRelax3.TabIndex = 34;
            this.btnRelax3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Engagement Level:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(628, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Relax Level:";
            // 
            // HistoryDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 662);
            this.ControlBox = false;
            this.Controls.Add(this.btnProductivity3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEngagement3);
            this.Controls.Add(this.btnRelax3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnProductivity2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEngagement2);
            this.Controls.Add(this.btnRelax2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnProductivity1);
            this.Controls.Add(this.lableConstant3);
            this.Controls.Add(this.btnEngagement1);
            this.Controls.Add(this.btnRelax1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelConstant1);
            this.Controls.Add(this.btnRealTime3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartHistory3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRealTime2);
            this.Controls.Add(this.chartHistory2);
            this.Controls.Add(this.bntRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.labelConstant2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.constantLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStaticData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butPauseResume);
            this.Controls.Add(this.btnRealTime);
            this.Controls.Add(this.chartHistory1);
            this.Name = "HistoryDataForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoryDataForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistory1;
        private System.Windows.Forms.Button btnRealTime;
        private System.Windows.Forms.Button butPauseResume;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStaticData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label constantLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelConstant2;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button bntRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistory2;
        private System.Windows.Forms.Button btnRealTime2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistory3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRealTime3;
        private System.Windows.Forms.Button btnProductivity1;
        private System.Windows.Forms.Label lableConstant3;
        private System.Windows.Forms.Button btnEngagement1;
        private System.Windows.Forms.Button btnRelax1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConstant1;
        private System.Windows.Forms.Button btnProductivity2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEngagement2;
        private System.Windows.Forms.Button btnRelax2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProductivity3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEngagement3;
        private System.Windows.Forms.Button btnRelax3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}