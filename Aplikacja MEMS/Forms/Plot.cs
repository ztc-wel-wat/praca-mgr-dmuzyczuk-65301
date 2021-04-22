using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_MEMS.Forms
{
    public partial class Plot : Form
    {
        public Plot(string name)
        {
            InitializeComponent();
            Text = name;
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

        public void AddPoints(float x)
        {
            chart.Invoke((Action)delegate
            {
                chart.Series[0].Points.InsertY(0, x);
            });
        }
             public void AddPoints(int[] dane)
        {
            chart.Invoke((Action)delegate
            {
                chart.Series[0].Points.InsertY(0, dane[0]);
                chart.Series[1].Points.InsertY(0, dane[1]);
                chart.Series[2].Points.InsertY(0, dane[2]);
            });
        }

        private void Plot_Load(object sender, EventArgs e)
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
    }
}
