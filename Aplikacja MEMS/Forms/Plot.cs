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

namespace Aplikacja_MEMS.Forms
{
    public partial class Plot : Form
    {
        public Plot(string name, int scale)
        {
            InitializeComponent();
            Text = name;

            if (scale > 1)
            {
                chart.ChartAreas[0].AxisY.Minimum = (-1) * scale * 1000;
                chart.ChartAreas[0].AxisY.Maximum = scale * 1000;
            }
            else if (scale == 0)
            {
                y.Visible = false;
                z.Visible = false;
            }
        }

        public void SetScale(int scale)
        {
            chart.Invoke((Action)delegate
            {
                chart.ChartAreas[0].AxisY.Minimum = (-1) * scale * 1000;
                chart.ChartAreas[0].AxisY.Maximum = scale * 1000;
            });
        }
        public void ClearPlot()
        {
            chart.Invoke((Action)delegate
            {
                chart.Series[0].Points.Clear();
                chart.Series[1].Points.Clear();
                chart.Series[2].Points.Clear();
            });
        }
        public void ShowMe()
        {
            Invoke((Action)delegate
            {
                Show();
                WindowState = FormWindowState.Normal;
            });
        }

        public void ExitPlot()
        {
            chart.Invoke((Action)delegate
            {
                Application.ExitThread();
            });
        }

        public void AddPoints(float[] x)
        {
            chart.Invoke((Action)delegate
            {
                chart.Series[0].Points.InsertY(0, x[0]);

                int time = BitConverter.ToInt32(BitConverter.GetBytes(x[1]), 0);
                DateTime timestamp = new DateTime(time);
                chart.Series[0].Points[0].Tag = timestamp.ToString("H:mm:ss.ffffff");
            });
        }

        public void AddPoints(int[] data)
        {
            chart.Invoke((Action)delegate
            {
                chart.Series[0].Points.InsertY(0, data[0]);
                chart.Series[1].Points.InsertY(0, data[1]);
                chart.Series[2].Points.InsertY(0, data[2]);

                DateTime timestamp = new DateTime(data[3]);
                chart.Series[0].Points[0].Tag = timestamp.ToString("H:mm:ss.ffffff");
            });
        }

        public void Plot_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void Plot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        Point? prevPosition = null;
        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;

            prevPosition = pos;
            var results = chart.HitTest(pos.X, pos.Y, false,
        ChartElementType.PlottingArea);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.PlottingArea)
                {
                    int value = Convert.ToInt32(result.ChartArea.AxisX.PixelPositionToValue(pos.X));

                    try
                    {
                        x.Text = ("X:" + chart.Series[0].Points[value].YValues[0].ToString("0.00"));
                        time.Text = (string)(chart.Series[0].Points[value].Tag);
                        y.Text = ("Y:" + chart.Series[1].Points[value].YValues[0].ToString("0.00"));
                        z.Text = ("Z:" + chart.Series[2].Points[value].YValues[0].ToString("0.00"));
                    }
                    catch { }

                }
            }

        }

        private void chart_MouseLeave(object sender, EventArgs e)
        {
            x.Text = "X:";
            y.Text = "Y:";
            z.Text = "Z:";
            time.Text = "Czas";
        }
    }
}
