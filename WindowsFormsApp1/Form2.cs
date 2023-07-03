using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public delegate void SetNewPoint(float Y, int X,int Graph);

    public partial class MainForm : Form
    {
        System.Windows.Forms.DataVisualization.Charting.Series series1;
        System.Windows.Forms.DataVisualization.Charting.Series series2;

        public void AddNewPoint(float Y, int X, int Graph)
        {
            switch (Graph)
            {
                case 0:
                    series1.Points.AddXY(X, Y);
                    break;
                case 1:
                    series2.Points.AddXY(X, Y);
                    break;

            }
            
        }  
        public void ClearSerries( int Graph)
        {
            switch (Graph)
            {
                case 0:
                    series1.Points.Clear();
                    break;
                case 1:
                    series2.Points.Clear();
                    break;

            }
        }
        public void SetName(string name, bool Graph) 
        {
         
            if (Graph == false)
            {
               
                this.series1.Name = name;
                this.series1.Color = Color.Red;
                this.chart2.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Red;
                this.chart2.ChartAreas[0].AxisY.LineColor= Color.Red;
                
            }
            else
            { 
                this.series2.Name = name;
                this.series2.Color = Color.Green;
                this.chart2.ChartAreas[0].AxisY2.LabelStyle.ForeColor = Color.Green;
                this.chart2.ChartAreas[0].AxisY2.LineColor = Color.Green;

            }
            
        }
        public MainForm()
        {
            series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
           
            Series[] DataSer = new Series[] { series1, series2 };
            series2.YAxisType = AxisType.Secondary;
            for (int i = 0; i < DataSer.Length; i++) 
            {
               
                DataSer[i].ChartType = SeriesChartType.Line;

            }
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        public void SetLegend(uint graph,string legend)
        {
                
        }

        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;
            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;
                    posXStart = Math.Round(posXStart, 0);
                    posXFinish = Math.Round(posXFinish, 0);
                    posYStart = Math.Round(posYStart, 1);
                    posYFinish = Math.Round(posYFinish, 1);
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
