
namespace SmartGarden
{
    partial class Form_Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_humidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_soil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_light = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_humidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_soil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_light)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart_humidity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart_soil, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart_temp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart_light, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 569);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chart_humidity
            // 
            this.chart_humidity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_humidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chart_humidity.BackImageTransparentColor = System.Drawing.Color.Gray;
            this.chart_humidity.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_humidity.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_humidity.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_humidity.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea5.BorderWidth = 0;
            chartArea5.Name = "ChartArea1";
            this.chart_humidity.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            legend5.Title = "Humidity";
            this.chart_humidity.Legends.Add(legend5);
            this.chart_humidity.Location = new System.Drawing.Point(3, 287);
            this.chart_humidity.Name = "chart_humidity";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.LabelForeColor = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "%";
            series5.ShadowColor = System.Drawing.Color.White;
            this.chart_humidity.Series.Add(series5);
            this.chart_humidity.Size = new System.Drawing.Size(391, 279);
            this.chart_humidity.TabIndex = 0;
            this.chart_humidity.Text = "chart1";
            // 
            // chart_soil
            // 
            this.chart_soil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_soil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chart_soil.BackImageTransparentColor = System.Drawing.Color.Gray;
            this.chart_soil.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_soil.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_soil.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_soil.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea6.BorderWidth = 0;
            chartArea6.Name = "ChartArea1";
            this.chart_soil.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            legend6.Title = "Soil";
            this.chart_soil.Legends.Add(legend6);
            this.chart_soil.Location = new System.Drawing.Point(400, 287);
            this.chart_soil.Name = "chart_soil";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.LabelForeColor = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "%";
            series6.ShadowColor = System.Drawing.Color.White;
            this.chart_soil.Series.Add(series6);
            this.chart_soil.Size = new System.Drawing.Size(391, 279);
            this.chart_soil.TabIndex = 0;
            this.chart_soil.Text = "chart1";
            // 
            // chart_temp
            // 
            this.chart_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart_temp.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart_temp.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart_temp.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_temp.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_temp.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_temp.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea7.BorderWidth = 0;
            chartArea7.Name = "ChartArea1";
            this.chart_temp.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            legend7.Title = "Temperature";
            this.chart_temp.Legends.Add(legend7);
            this.chart_temp.Location = new System.Drawing.Point(400, 3);
            this.chart_temp.Name = "chart_temp";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.LabelForeColor = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "°C";
            series7.ShadowColor = System.Drawing.Color.White;
            this.chart_temp.Series.Add(series7);
            this.chart_temp.Size = new System.Drawing.Size(391, 278);
            this.chart_temp.TabIndex = 0;
            this.chart_temp.Text = "chart1";
            // 
            // chart_light
            // 
            this.chart_light.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart_light.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart_light.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart_light.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_light.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_light.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_light.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea8.BorderWidth = 0;
            chartArea8.Name = "ChartArea1";
            this.chart_light.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            legend8.Title = "Light";
            this.chart_light.Legends.Add(legend8);
            this.chart_light.Location = new System.Drawing.Point(3, 3);
            this.chart_light.Name = "chart_light";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.LabelForeColor = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "Lux";
            series8.ShadowColor = System.Drawing.Color.White;
            this.chart_light.Series.Add(series8);
            this.chart_light.Size = new System.Drawing.Size(391, 278);
            this.chart_light.TabIndex = 0;
            this.chart_light.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(794, 569);
            this.panel5.TabIndex = 5;
            // 
            // Form_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 569);
            this.Controls.Add(this.panel5);
            this.Name = "Form_Chart";
            this.Text = "Form1_Chart";
            this.Load += new System.EventHandler(this.Form1_Chart_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_humidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_soil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_light)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_humidity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_soil;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_light;
        private System.Windows.Forms.Panel panel5;
    }
}