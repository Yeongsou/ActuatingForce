using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Diagnostics;
using System.Drawing; 
using System;

namespace ActuatingForce
{
    public partial class frmHome : Form
    {
        private System.Timers.Timer tmrDistance;
        private System.Timers.Timer tmrForce;
        double valX = -0.3;

        public frmHome()
        {
            InitializeComponent();

            setChartDesign(this.chart1);


            tmrDistance = new System.Timers.Timer(100);
            tmrDistance.Elapsed += OnTimeDistance;
            tmrDistance.AutoReset = true;
            //tmrDistance.Enabled = true;

            tmrForce = new System.Timers.Timer(400);
            tmrForce.Elapsed += OnTimeForce;
            tmrForce.AutoReset = true;
            //tmrForce.Enabled = true;
        }





        private void setChartDesign(Chart ct)
        { 
            ct.Series[0].ChartType = SeriesChartType.FastLine;

            ct.ChartAreas[0].Visible = true;
            ct.ChartAreas[0].AxisX.Title = "작동 거리 [mm]";
            ct.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            ct.ChartAreas[0].AxisX.TitleForeColor = Color.Gainsboro;
            ct.ChartAreas[0].AxisX.Minimum = 0;
            ct.ChartAreas[0].AxisX.Maximum = 200;
            ct.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            ct.ChartAreas[0].AxisX.MajorGrid.Interval = 10;
            ct.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(10, 10, 10);

            ct.ChartAreas[0].AxisY.Title = "TRACK 작동력 [kg.f]";
            ct.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            ct.ChartAreas[0].AxisY.TitleForeColor = Color.Gainsboro;
            ct.ChartAreas[0].AxisY.Minimum = -30;
            ct.ChartAreas[0].AxisY.Maximum = 30; 
            ct.ChartAreas[0].AxisY.MajorGrid.Interval = 30;
            ct.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(40, 40, 40);
            ct.ChartAreas[0].AxisY.MinorGrid.Interval = 10;
            ct.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.FromArgb(10, 10, 10);

            ct.Legends[0].Enabled = false; 

            ct.Series[0].Points.Clear();
            ct.Series[0].Points.AddXY(0, 0);  
        }
         

        private void OnTimeDistance(object sender, EventArgs e)
        {
            if (valX >= 201)
            { 
                valX = -0.3;
            }
            valX = valX + 0.3;
        }


        private void OnTimeForce(object sender, EventArgs e)
        {
            Random rand = new Random();
            double ranVal = (double)rand.Next(-30, 30);

            this.SynchronizedInvoke(() =>
            {
                this.chart1.Series[0].Color = Color.SteelBlue;

                this.chart1.Series[0].Points.AddXY(valX, ranVal);
                this.proTrackForce.Value = ranVal;
                this.proLeverForce.Value = ranVal / 2;
                this.proWalkForce.Value = ranVal * (0.2 - 1);
                this.proTrackDistance.Value = valX;
                this.proLaserBack.Value = valX / 5;
                this.proLaserUpper.Value = valX / 4;
                this.proLaserLower1.Value = valX / 6;
                this.proLaserLower2.Value = valX / 5;

                if (valX >= 200)
                {
                    this.chart1.Series[0].Points.Clear();
                    this.chart1.Series[0].Points.AddXY(0, 0);
                }
            });

        }

        private void btnTestGraph_Click(object sender, EventArgs e)
        {
            if (btnTestGraph.Text == "Test")
            {
                tmrDistance.Start();
                tmrForce.Start();
                btnTestGraph.Text = "Stop";
            }
            else
            {
                tmrDistance.Stop();
                tmrForce.Stop();
                btnTestGraph.Text = "Test";
            }
        }
    }
}
