
namespace Aplikacja_MEMS.Forms
{
    partial class Plot
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
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation4 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plot));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            textAnnotation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            textAnnotation1.Name = "x";
            textAnnotation1.Text = "X:";
            textAnnotation1.X = 30D;
            textAnnotation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            textAnnotation2.Name = "y";
            textAnnotation2.Text = "Y;";
            textAnnotation2.X = 50D;
            textAnnotation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            textAnnotation3.Name = "z";
            textAnnotation3.Text = "Z:";
            textAnnotation3.X = 70D;
            textAnnotation4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            textAnnotation4.Name = "time";
            textAnnotation4.Text = "TIME";
            textAnnotation4.X = 10D;
            this.chart.Annotations.Add(textAnnotation1);
            this.chart.Annotations.Add(textAnnotation2);
            this.chart.Annotations.Add(textAnnotation3);
            this.chart.Annotations.Add(textAnnotation4);
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScaleView.Position = 0D;
            chartArea1.AxisX.ScaleView.Size = 100D;
            chartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "X";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Y";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Z";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(884, 517);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            this.chart.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.Color.White;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x.ForeColor = System.Drawing.Color.DodgerBlue;
            this.x.Location = new System.Drawing.Point(270, 3);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(23, 17);
            this.x.TabIndex = 1;
            this.x.Text = "X:";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.BackColor = System.Drawing.Color.White;
            this.y.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.y.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.y.Location = new System.Drawing.Point(447, 3);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(23, 17);
            this.y.TabIndex = 2;
            this.y.Text = "Y:";
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.BackColor = System.Drawing.Color.White;
            this.z.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.z.ForeColor = System.Drawing.Color.Crimson;
            this.z.Location = new System.Drawing.Point(623, 3);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(23, 17);
            this.z.TabIndex = 3;
            this.z.Text = "Z:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.White;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time.Location = new System.Drawing.Point(98, 3);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(39, 17);
            this.time.TabIndex = 4;
            this.time.Text = "Time";
            // 
            // Plot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 517);
            this.Controls.Add(this.time);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 556);
            this.Name = "Plot";
            this.Text = "Plot";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Plot_FormClosing);
            this.Load += new System.EventHandler(this.Plot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Label time;
    }
}