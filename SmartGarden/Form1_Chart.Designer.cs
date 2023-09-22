
namespace SmartGarden
{
    partial class Form1_Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_light = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_humidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart_temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart_soil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_light)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_humidity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_soil)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_light
            // 
            this.chart_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart_light.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart_light.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart_light.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_light.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_light.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_light.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart_light.ChartAreas.Add(chartArea1);
            this.chart_light.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Title = "Light";
            this.chart_light.Legends.Add(legend1);
            this.chart_light.Location = new System.Drawing.Point(0, 0);
            this.chart_light.Name = "chart_light";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Lux";
            series1.ShadowColor = System.Drawing.Color.White;
            this.chart_light.Series.Add(series1);
            this.chart_light.Size = new System.Drawing.Size(576, 373);
            this.chart_light.TabIndex = 0;
            this.chart_light.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart_light);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 373);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart_humidity);
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 373);
            this.panel2.TabIndex = 2;
            // 
            // chart_humidity
            // 
            this.chart_humidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chart_humidity.BackImageTransparentColor = System.Drawing.Color.Gray;
            this.chart_humidity.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_humidity.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_humidity.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_humidity.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart_humidity.ChartAreas.Add(chartArea2);
            this.chart_humidity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            legend2.Title = "Humidity";
            this.chart_humidity.Legends.Add(legend2);
            this.chart_humidity.Location = new System.Drawing.Point(0, 0);
            this.chart_humidity.Name = "chart_humidity";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "%";
            series2.ShadowColor = System.Drawing.Color.White;
            this.chart_humidity.Series.Add(series2);
            this.chart_humidity.Size = new System.Drawing.Size(576, 373);
            this.chart_humidity.TabIndex = 0;
            this.chart_humidity.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart_temp);
            this.panel3.Location = new System.Drawing.Point(582, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 373);
            this.panel3.TabIndex = 2;
            // 
            // chart_temp
            // 
            this.chart_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart_temp.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart_temp.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart_temp.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_temp.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_temp.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_temp.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea3.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart_temp.ChartAreas.Add(chartArea3);
            this.chart_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            legend3.Title = "Temperature";
            this.chart_temp.Legends.Add(legend3);
            this.chart_temp.Location = new System.Drawing.Point(0, 0);
            this.chart_temp.Name = "chart_temp";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.LabelForeColor = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "°C";
            series3.ShadowColor = System.Drawing.Color.White;
            this.chart_temp.Series.Add(series3);
            this.chart_temp.Size = new System.Drawing.Size(576, 373);
            this.chart_temp.TabIndex = 0;
            this.chart_temp.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart_soil);
            this.panel4.Location = new System.Drawing.Point(582, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 373);
            this.panel4.TabIndex = 3;
            // 
            // chart_soil
            // 
            this.chart_soil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chart_soil.BackImageTransparentColor = System.Drawing.Color.Gray;
            this.chart_soil.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_soil.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_soil.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_soil.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea4.BorderWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.chart_soil.ChartAreas.Add(chartArea4);
            this.chart_soil.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            legend4.Title = "Soil";
            this.chart_soil.Legends.Add(legend4);
            this.chart_soil.Location = new System.Drawing.Point(0, 0);
            this.chart_soil.Name = "chart_soil";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.LabelForeColor = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "%";
            series4.ShadowColor = System.Drawing.Color.White;
            this.chart_soil.Series.Add(series4);
            this.chart_soil.Size = new System.Drawing.Size(576, 373);
            this.chart_soil.TabIndex = 0;
            this.chart_soil.Text = "chart1";
            // 
            // Form1_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 569);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1_Chart";
            this.Text = "Form1_Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_light)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_humidity)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_soil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_light;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_humidity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_temp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_soil;
    }
}