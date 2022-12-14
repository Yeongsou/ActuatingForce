namespace ActuatingForce
{
    partial class frmHome
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTestGraph = new System.Windows.Forms.Button();
            this.proTrackDistance = new ActuatingForce.ProgressType2_FillUp();
            this.proWalkForce = new ActuatingForce.ProgressType2_FillUp();
            this.proTrackForce = new ActuatingForce.ProgressType2_FillUp();
            this.proLeverForce = new ActuatingForce.ProgressType2_FillUp();
            this.proLaserUpper = new ActuatingForce.ProgressType2_FillUp();
            this.proLaserLower1 = new ActuatingForce.ProgressType2_FillUp();
            this.proLaserLower2 = new ActuatingForce.ProgressType2_FillUp();
            this.proLaserBack = new ActuatingForce.ProgressType2_FillUp();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.proLaserUpper);
            this.panel1.Controls.Add(this.proLaserLower1);
            this.panel1.Controls.Add(this.proLaserLower2);
            this.panel1.Controls.Add(this.proLaserBack);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(437, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 143);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(334, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "레이저 하부 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(226, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "레이저 하부 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(118, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "레이저 상부 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "레이저 후방 1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.proWalkForce);
            this.panel2.Controls.Add(this.proTrackForce);
            this.panel2.Controls.Add(this.proLeverForce);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 143);
            this.panel2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(220, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Walk-IN 작동력";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(121, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Lever 작동력";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(13, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Track 작동력";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Controls.Add(this.proTrackDistance);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Location = new System.Drawing.Point(325, 1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(111, 143);
            this.panel12.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Track 작동거리";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea2.AxisX.Interval = 10D;
            chartArea2.AxisX.MajorGrid.Interval = 10D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            chartArea2.AxisX.Maximum = 200D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "작동 거리 [ mm ]";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.MajorGrid.Interval = 30D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea2.AxisY.Maximum = 30D;
            chartArea2.AxisY.Minimum = -30D;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.Interval = 10D;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            chartArea2.AxisY.Title = "TRACK 작동력 [kg.f]";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1, 145);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(871, 465);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnTestGraph
            // 
            this.btnTestGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTestGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestGraph.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTestGraph.Location = new System.Drawing.Point(824, 586);
            this.btnTestGraph.Name = "btnTestGraph";
            this.btnTestGraph.Size = new System.Drawing.Size(44, 20);
            this.btnTestGraph.TabIndex = 21;
            this.btnTestGraph.Text = "Test";
            this.btnTestGraph.UseVisualStyleBackColor = false;
            this.btnTestGraph.Click += new System.EventHandler(this.btnTestGraph_Click);
            // 
            // proTrackDistance
            // 
            this.proTrackDistance.AngleRange = 280;
            this.proTrackDistance.AngleRangeStyle = ActuatingForce.ProgressType2_FillUp._AngleRangeStyle.Auto;
            this.proTrackDistance.AngleStart = -230;
            this.proTrackDistance.BackColor = System.Drawing.Color.Black;
            this.proTrackDistance.Blank = 3;
            this.proTrackDistance.DecimalPlaces = ActuatingForce.ProgressType2_FillUp._DecimalPlaces.두번째;
            this.proTrackDistance.DivideVal = 10;
            this.proTrackDistance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proTrackDistance.ForeColor = System.Drawing.Color.PaleGreen;
            this.proTrackDistance.Location = new System.Drawing.Point(7, 6);
            this.proTrackDistance.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.proTrackDistance.Maximum = 210D;
            this.proTrackDistance.Minimum = 0D;
            this.proTrackDistance.MinimumSize = new System.Drawing.Size(80, 80);
            this.proTrackDistance.MinMaxFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proTrackDistance.MinMaxForeColor = System.Drawing.Color.Gainsboro;
            this.proTrackDistance.Name = "proTrackDistance";
            this.proTrackDistance.ProgressColorBase = System.Drawing.Color.DarkGray;
            this.proTrackDistance.ProgressShape = ActuatingForce.ProgressType2_FillUp._ProgressShape.Flat;
            this.proTrackDistance.Size = new System.Drawing.Size(96, 106);
            this.proTrackDistance.SpecColor_IN = System.Drawing.Color.GreenYellow;
            this.proTrackDistance.SpecColor_OUT = System.Drawing.Color.PaleVioletRed;
            this.proTrackDistance.SpecLow = 100F;
            this.proTrackDistance.SpecUp = 210F;
            this.proTrackDistance.TabIndex = 24;
            this.proTrackDistance.Value = 80D;
            // 
            // proWalkForce
            // 
            this.proWalkForce.AngleRange = 280;
            this.proWalkForce.AngleRangeStyle = ActuatingForce.ProgressType2_FillUp._AngleRangeStyle.Auto;
            this.proWalkForce.AngleStart = -230;
            this.proWalkForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.proWalkForce.Blank = 3;
            this.proWalkForce.DecimalPlaces = ActuatingForce.ProgressType2_FillUp._DecimalPlaces.두번째;
            this.proWalkForce.DivideVal = 10;
            this.proWalkForce.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proWalkForce.ForeColor = System.Drawing.Color.PaleGreen;
            this.proWalkForce.Location = new System.Drawing.Point(223, 6);
            this.proWalkForce.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.proWalkForce.Maximum = 30D;
            this.proWalkForce.Minimum = -30D;
            this.proWalkForce.MinimumSize = new System.Drawing.Size(80, 80);
            this.proWalkForce.MinMaxFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proWalkForce.MinMaxForeColor = System.Drawing.Color.Gainsboro;
            this.proWalkForce.Name = "proWalkForce";
            this.proWalkForce.ProgressColorBase = System.Drawing.Color.DarkGray;
            this.proWalkForce.ProgressShape = ActuatingForce.ProgressType2_FillUp._ProgressShape.Flat;
            this.proWalkForce.Size = new System.Drawing.Size(96, 106);
            this.proWalkForce.SpecColor_IN = System.Drawing.Color.Khaki;
            this.proWalkForce.SpecColor_OUT = System.Drawing.Color.LightSalmon;
            this.proWalkForce.SpecLow = 0F;
            this.proWalkForce.SpecUp = 30F;
            this.proWalkForce.TabIndex = 27;
            this.proWalkForce.Value = 15D;
            // 
            // proTrackForce
            // 
            this.proTrackForce.AngleRange = 280;
            this.proTrackForce.AngleRangeStyle = ActuatingForce.ProgressType2_FillUp._AngleRangeStyle.Auto;
            this.proTrackForce.AngleStart = -230;
            this.proTrackForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.proTrackForce.Blank = 3;
            this.proTrackForce.DecimalPlaces = ActuatingForce.ProgressType2_FillUp._DecimalPlaces.두번째;
            this.proTrackForce.DivideVal = 10;
            this.proTrackForce.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proTrackForce.ForeColor = System.Drawing.Color.PaleGreen;
            this.proTrackForce.Location = new System.Drawing.Point(7, 6);
            this.proTrackForce.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.proTrackForce.Maximum = 30D;
            this.proTrackForce.Minimum = -30D;
            this.proTrackForce.MinimumSize = new System.Drawing.Size(80, 80);
            this.proTrackForce.MinMaxFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proTrackForce.MinMaxForeColor = System.Drawing.Color.Gainsboro;
            this.proTrackForce.Name = "proTrackForce";
            this.proTrackForce.ProgressColorBase = System.Drawing.Color.DarkGray;
            this.proTrackForce.ProgressShape = ActuatingForce.ProgressType2_FillUp._ProgressShape.Flat;
            this.proTrackForce.Size = new System.Drawing.Size(96, 106);
            this.proTrackForce.SpecColor_IN = System.Drawing.Color.Khaki;
            this.proTrackForce.SpecColor_OUT = System.Drawing.Color.LightSalmon;
            this.proTrackForce.SpecLow = 0F;
            this.proTrackForce.SpecUp = 30F;
            this.proTrackForce.TabIndex = 27;
            this.proTrackForce.Value = -10D;
            // 
            // proLeverForce
            // 
            this.proLeverForce.AngleRange = 280;
            this.proLeverForce.AngleRangeStyle = ActuatingForce.ProgressType2_FillUp._AngleRangeStyle.Auto;
            this.proLeverForce.AngleStart = -230;
            this.proLeverForce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.proLeverForce.Blank = 3;
            this.proLeverForce.DecimalPlaces = ActuatingForce.ProgressType2_FillUp._DecimalPlaces.두번째;
            this.proLeverForce.DivideVal = 10;
            this.proLeverForce.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLeverForce.ForeColor = System.Drawing.Color.PaleGreen;
            this.proLeverForce.Location = new System.Drawing.Point(115, 6);
            this.proLeverForce.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.proLeverForce.Maximum = 30D;
            this.proLeverForce.Minimum = -30D;
            this.proLeverForce.MinimumSize = new System.Drawing.Size(80, 80);
            this.proLeverForce.MinMaxFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLeverForce.MinMaxForeColor = System.Drawing.Color.Gainsboro;
            this.proLeverForce.Name = "proLeverForce";
            this.proLeverForce.ProgressColorBase = System.Drawing.Color.DarkGray;
            this.proLeverForce.ProgressShape = ActuatingForce.ProgressType2_FillUp._ProgressShape.Flat;
            this.proLeverForce.Size = new System.Drawing.Size(96, 106);
            this.proLeverForce.SpecColor_IN = System.Drawing.Color.Khaki;
            this.proLeverForce.SpecColor_OUT = System.Drawing.Color.LightSalmon;
            this.proLeverForce.SpecLow = 0F;
            this.proLeverForce.SpecUp = 30F;
            this.proLeverForce.TabIndex = 27;
            this.proLeverForce.Value = 25D;
            // 
            // proLaserUpper
            // 
            this.proLaserUpper.AngleRange = 280;
            this.proLaserUpper.AngleRangeStyle = ActuatingForce.ProgressType2_FillUp._AngleRangeStyle.Auto;
            this.proLaserUpper.AngleStart = -230;
            this.proLaserUpper.BackColor = System.Drawing.Color.Black;
            this.proLaserUpper.Blank = 3;
            this.proLaserUpper.DecimalPlaces = ActuatingForce.ProgressType2_FillUp._DecimalPlaces.두번째;
            this.proLaserUpper.DivideVal = 10;
            this.proLaserUpper.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLaserUpper.ForeColor = System.Drawing.Color.PaleGreen;
            this.proLaserUpper.Location = new System.Drawing.Point(115, 6);
            this.proLaserUpper.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.proLaserUpper.Maximum = 50D;
            this.proLaserUpper.Minimum = 0D;
            this.proLaserUpper.MinimumSize = new System.Drawing.Size(80, 80);
            this.proLaserUpper.MinMaxFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLaserUpper.MinMaxForeColor = System.Drawing.Color.Gainsboro;
            this.proLaserUpper.Name = "proLaserUpper";
            this.proLaserUpper.ProgressColorBase = System.Drawing.Color.DarkGray;
            this.proLaserUpper.ProgressShape = ActuatingForce.ProgressType2_FillUp._ProgressShape.Flat;
            this.proLaserUpper.Size = new System.Drawing.Size(96, 106);
            this.proLaserUpper.SpecColor_IN = System.Drawing.Color.GreenYellow;
            this.proLaserUpper.SpecColor_OUT = System.Drawing.Color.PaleVioletRed;
            this.proLaserUpper.SpecLow = 20F;
            this.proLaserUpper.SpecUp = 45F;
            this.proLaserUpper.TabIndex = 24;
            this.proLaserUpper.Value = 25D;
            // 
            // proLaserLower1
            // 
            this.proLaserLower1.AngleRange = 280;
            this.proLaserLower1.AngleRangeStyle = ActuatingForce.ProgressType2_FillUp._AngleRangeStyle.Auto;
            this.proLaserLower1.AngleStart = -230;
            this.proLaserLower1.BackColor = System.Drawing.Color.Black;
            this.proLaserLower1.Blank = 3;
            this.proLaserLower1.DecimalPlaces = ActuatingForce.ProgressType2_FillUp._DecimalPlaces.두번째;
            this.proLaserLower1.DivideVal = 10;
            this.proLaserLower1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLaserLower1.ForeColor = System.Drawing.Color.PaleGreen;
            this.proLaserLower1.Location = new System.Drawing.Point(223, 6);
            this.proLaserLower1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.proLaserLower1.Maximum = 50D;
            this.proLaserLower1.Minimum = 0D;
            this.proLaserLower1.MinimumSize = new System.Drawing.Size(80, 80);
            this.proLaserLower1.MinMaxFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLaserLower1.MinMaxForeColor = System.Drawing.Color.Gainsboro;
            this.proLaserLower1.Name = "proLaserLower1";
            this.proLaserLower1.ProgressColorBase = System.Drawing.Color.DarkGray;
            this.proLaserLower1.ProgressShape = ActuatingForce.ProgressType2_FillUp._ProgressShape.Flat;
            this.proLaserLower1.Size = new System.Drawing.Size(96, 106);
            this.proLaserLower1.SpecColor_IN = System.Drawing.Color.GreenYellow;
            this.proLaserLower1.SpecColor_OUT = System.Drawing.Color.PaleVioletRed;
            this.proLaserLower1.SpecLow = 20F;
            this.proLaserLower1.SpecUp = 45F;
            this.proLaserLower1.TabIndex = 24;
            this.proLaserLower1.Value = 40D;
            // 
            // proLaserLower2
            // 
            this.proLaserLower2.AngleRange = 280;
            this.proLaserLower2.AngleRangeStyle = ActuatingForce.ProgressType2_FillUp._AngleRangeStyle.Auto;
            this.proLaserLower2.AngleStart = -230;
            this.proLaserLower2.BackColor = System.Drawing.Color.Black;
            this.proLaserLower2.Blank = 3;
            this.proLaserLower2.DecimalPlaces = ActuatingForce.ProgressType2_FillUp._DecimalPlaces.두번째;
            this.proLaserLower2.DivideVal = 10;
            this.proLaserLower2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLaserLower2.ForeColor = System.Drawing.Color.PaleGreen;
            this.proLaserLower2.Location = new System.Drawing.Point(331, 6);
            this.proLaserLower2.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.proLaserLower2.Maximum = 50D;
            this.proLaserLower2.Minimum = 0D;
            this.proLaserLower2.MinimumSize = new System.Drawing.Size(80, 80);
            this.proLaserLower2.MinMaxFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLaserLower2.MinMaxForeColor = System.Drawing.Color.Gainsboro;
            this.proLaserLower2.Name = "proLaserLower2";
            this.proLaserLower2.ProgressColorBase = System.Drawing.Color.DarkGray;
            this.proLaserLower2.ProgressShape = ActuatingForce.ProgressType2_FillUp._ProgressShape.Flat;
            this.proLaserLower2.Size = new System.Drawing.Size(96, 106);
            this.proLaserLower2.SpecColor_IN = System.Drawing.Color.GreenYellow;
            this.proLaserLower2.SpecColor_OUT = System.Drawing.Color.PaleVioletRed;
            this.proLaserLower2.SpecLow = 20F;
            this.proLaserLower2.SpecUp = 45F;
            this.proLaserLower2.TabIndex = 24;
            this.proLaserLower2.Value = 47D;
            // 
            // proLaserBack
            // 
            this.proLaserBack.AngleRange = 280;
            this.proLaserBack.AngleRangeStyle = ActuatingForce.ProgressType2_FillUp._AngleRangeStyle.Auto;
            this.proLaserBack.AngleStart = -230;
            this.proLaserBack.BackColor = System.Drawing.Color.Black;
            this.proLaserBack.Blank = 3;
            this.proLaserBack.DecimalPlaces = ActuatingForce.ProgressType2_FillUp._DecimalPlaces.두번째;
            this.proLaserBack.DivideVal = 10;
            this.proLaserBack.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLaserBack.ForeColor = System.Drawing.Color.PaleGreen;
            this.proLaserBack.Location = new System.Drawing.Point(7, 6);
            this.proLaserBack.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.proLaserBack.Maximum = 50D;
            this.proLaserBack.Minimum = 0D;
            this.proLaserBack.MinimumSize = new System.Drawing.Size(80, 80);
            this.proLaserBack.MinMaxFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proLaserBack.MinMaxForeColor = System.Drawing.Color.Gainsboro;
            this.proLaserBack.Name = "proLaserBack";
            this.proLaserBack.ProgressColorBase = System.Drawing.Color.DarkGray;
            this.proLaserBack.ProgressShape = ActuatingForce.ProgressType2_FillUp._ProgressShape.Flat;
            this.proLaserBack.Size = new System.Drawing.Size(96, 106);
            this.proLaserBack.SpecColor_IN = System.Drawing.Color.GreenYellow;
            this.proLaserBack.SpecColor_OUT = System.Drawing.Color.PaleVioletRed;
            this.proLaserBack.SpecLow = 20F;
            this.proLaserBack.SpecUp = 45F;
            this.proLaserBack.TabIndex = 24;
            this.proLaserBack.Value = 7D;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1276, 904);
            this.Controls.Add(this.btnTestGraph);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ProgressType2_FillUp proLaserLower2;
        private ProgressType2_FillUp proLaserLower1;
        private ProgressType2_FillUp proLaserUpper;
        private ProgressType2_FillUp proLaserBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private ProgressType2_FillUp proLeverForce;
        private ProgressType2_FillUp proTrackForce;
        private ProgressType2_FillUp proWalkForce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel12;
        private ProgressType2_FillUp proTrackDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnTestGraph;
    }
}