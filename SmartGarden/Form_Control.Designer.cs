
using System;
using System.Threading;
using System.Windows;

namespace SmartGarden
{
    partial class Form_Control
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
        /// 
       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Control));
            this.chart_Light = new LiveCharts.WinForms.SolidGauge();
            this.timer_data = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_highLight = new System.Windows.Forms.Button();
            this.btn_lowLight = new System.Windows.Forms.Button();
            this.lb_high_light = new System.Windows.Forms.Label();
            this.txt_high_light = new System.Windows.Forms.TextBox();
            this.lb_low_light = new System.Windows.Forms.Label();
            this.txt_low_light = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_highTemp = new System.Windows.Forms.Button();
            this.btn_lowTemp = new System.Windows.Forms.Button();
            this.lb_high_temp = new System.Windows.Forms.Label();
            this.txt_high_Temp = new System.Windows.Forms.TextBox();
            this.lb_low_temp = new System.Windows.Forms.Label();
            this.txt_low_Temp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chart_Temp = new LiveCharts.WinForms.SolidGauge();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_highHumi = new System.Windows.Forms.Button();
            this.btn_lowHumi = new System.Windows.Forms.Button();
            this.lb_high_humi = new System.Windows.Forms.Label();
            this.txt_high_Humi = new System.Windows.Forms.TextBox();
            this.lb_low_humi = new System.Windows.Forms.Label();
            this.txt_low_Humi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chart_Humi = new LiveCharts.WinForms.SolidGauge();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_highSoil = new System.Windows.Forms.Button();
            this.btn_lowSoil = new System.Windows.Forms.Button();
            this.lb_high_soil = new System.Windows.Forms.Label();
            this.txt_high_Soil = new System.Windows.Forms.TextBox();
            this.lb_low_soil = new System.Windows.Forms.Label();
            this.txt_low_Soil = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chart_Soil = new LiveCharts.WinForms.SolidGauge();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_Light
            // 
            this.chart_Light.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_Light.Location = new System.Drawing.Point(56, 74);
            this.chart_Light.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Light.Name = "chart_Light";
            this.chart_Light.Size = new System.Drawing.Size(149, 185);
            this.chart_Light.TabIndex = 2;
            this.chart_Light.Text = "solidGauge1";
            // 
            // timer_data
            // 
            this.timer_data.Tick += new System.EventHandler(this.timer_data_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_highLight);
            this.panel1.Controls.Add(this.btn_lowLight);
            this.panel1.Controls.Add(this.lb_high_light);
            this.panel1.Controls.Add(this.txt_high_light);
            this.panel1.Controls.Add(this.lb_low_light);
            this.panel1.Controls.Add(this.txt_low_light);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chart_Light);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 360);
            this.panel1.TabIndex = 3;
            // 
            // btn_highLight
            // 
            this.btn_highLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_highLight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highLight.Location = new System.Drawing.Point(168, 302);
            this.btn_highLight.Name = "btn_highLight";
            this.btn_highLight.Size = new System.Drawing.Size(75, 36);
            this.btn_highLight.TabIndex = 12;
            this.btn_highLight.Text = "Set";
            this.btn_highLight.UseVisualStyleBackColor = false;
            this.btn_highLight.Click += new System.EventHandler(this.btn_highLight_Click);
            // 
            // btn_lowLight
            // 
            this.btn_lowLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lowLight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowLight.Location = new System.Drawing.Point(14, 303);
            this.btn_lowLight.Name = "btn_lowLight";
            this.btn_lowLight.Size = new System.Drawing.Size(75, 36);
            this.btn_lowLight.TabIndex = 11;
            this.btn_lowLight.Text = "Set";
            this.btn_lowLight.UseVisualStyleBackColor = false;
            this.btn_lowLight.Click += new System.EventHandler(this.btn_lowLight_Click);
            // 
            // lb_high_light
            // 
            this.lb_high_light.AutoSize = true;
            this.lb_high_light.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_high_light.Location = new System.Drawing.Point(202, 238);
            this.lb_high_light.Name = "lb_high_light";
            this.lb_high_light.Size = new System.Drawing.Size(0, 21);
            this.lb_high_light.TabIndex = 10;
            // 
            // txt_high_light
            // 
            this.txt_high_light.Location = new System.Drawing.Point(168, 267);
            this.txt_high_light.Name = "txt_high_light";
            this.txt_high_light.Size = new System.Drawing.Size(75, 29);
            this.txt_high_light.TabIndex = 8;
            // 
            // lb_low_light
            // 
            this.lb_low_light.AutoSize = true;
            this.lb_low_light.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_low_light.Location = new System.Drawing.Point(52, 238);
            this.lb_low_light.Name = "lb_low_light";
            this.lb_low_light.Size = new System.Drawing.Size(0, 21);
            this.lb_low_light.TabIndex = 9;
            // 
            // txt_low_light
            // 
            this.txt_low_light.Location = new System.Drawing.Point(14, 267);
            this.txt_low_light.Name = "txt_low_light";
            this.txt_low_light.Size = new System.Drawing.Size(75, 29);
            this.txt_low_light.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "High:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Low:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Light";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btn_highTemp);
            this.panel2.Controls.Add(this.btn_lowTemp);
            this.panel2.Controls.Add(this.lb_high_temp);
            this.panel2.Controls.Add(this.txt_high_Temp);
            this.panel2.Controls.Add(this.lb_low_temp);
            this.panel2.Controls.Add(this.txt_low_Temp);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.chart_Temp);
            this.panel2.Location = new System.Drawing.Point(272, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 360);
            this.panel2.TabIndex = 13;
            // 
            // btn_highTemp
            // 
            this.btn_highTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_highTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highTemp.Location = new System.Drawing.Point(168, 302);
            this.btn_highTemp.Name = "btn_highTemp";
            this.btn_highTemp.Size = new System.Drawing.Size(75, 36);
            this.btn_highTemp.TabIndex = 12;
            this.btn_highTemp.Text = "Set";
            this.btn_highTemp.UseVisualStyleBackColor = false;
            this.btn_highTemp.Click += new System.EventHandler(this.btn_highTemp_Click);
            // 
            // btn_lowTemp
            // 
            this.btn_lowTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lowTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowTemp.Location = new System.Drawing.Point(14, 303);
            this.btn_lowTemp.Name = "btn_lowTemp";
            this.btn_lowTemp.Size = new System.Drawing.Size(75, 36);
            this.btn_lowTemp.TabIndex = 11;
            this.btn_lowTemp.Text = "Set";
            this.btn_lowTemp.UseVisualStyleBackColor = false;
            this.btn_lowTemp.Click += new System.EventHandler(this.btn_lowTemp_Click);
            // 
            // lb_high_temp
            // 
            this.lb_high_temp.AutoSize = true;
            this.lb_high_temp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_high_temp.Location = new System.Drawing.Point(202, 238);
            this.lb_high_temp.Name = "lb_high_temp";
            this.lb_high_temp.Size = new System.Drawing.Size(52, 21);
            this.lb_high_temp.TabIndex = 10;
            this.lb_high_temp.Text = "label5";
            // 
            // txt_high_Temp
            // 
            this.txt_high_Temp.Location = new System.Drawing.Point(168, 267);
            this.txt_high_Temp.Name = "txt_high_Temp";
            this.txt_high_Temp.Size = new System.Drawing.Size(75, 29);
            this.txt_high_Temp.TabIndex = 8;
            // 
            // lb_low_temp
            // 
            this.lb_low_temp.AutoSize = true;
            this.lb_low_temp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_low_temp.Location = new System.Drawing.Point(52, 238);
            this.lb_low_temp.Name = "lb_low_temp";
            this.lb_low_temp.Size = new System.Drawing.Size(52, 21);
            this.lb_low_temp.TabIndex = 9;
            this.lb_low_temp.Text = "label4";
            // 
            // txt_low_Temp
            // 
            this.txt_low_Temp.Location = new System.Drawing.Point(14, 267);
            this.txt_low_Temp.Name = "txt_low_Temp";
            this.txt_low_Temp.Size = new System.Drawing.Size(75, 29);
            this.txt_low_Temp.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "High:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Low:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(88, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Temperature";
            // 
            // chart_Temp
            // 
            this.chart_Temp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_Temp.Location = new System.Drawing.Point(56, 74);
            this.chart_Temp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Temp.Name = "chart_Temp";
            this.chart_Temp.Size = new System.Drawing.Size(149, 185);
            this.chart_Temp.TabIndex = 2;
            this.chart_Temp.Text = "solidGauge1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btn_highHumi);
            this.panel3.Controls.Add(this.btn_lowHumi);
            this.panel3.Controls.Add(this.lb_high_humi);
            this.panel3.Controls.Add(this.txt_high_Humi);
            this.panel3.Controls.Add(this.lb_low_humi);
            this.panel3.Controls.Add(this.txt_low_Humi);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.chart_Humi);
            this.panel3.Location = new System.Drawing.Point(542, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 360);
            this.panel3.TabIndex = 14;
            // 
            // btn_highHumi
            // 
            this.btn_highHumi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_highHumi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highHumi.Location = new System.Drawing.Point(168, 302);
            this.btn_highHumi.Name = "btn_highHumi";
            this.btn_highHumi.Size = new System.Drawing.Size(75, 36);
            this.btn_highHumi.TabIndex = 12;
            this.btn_highHumi.Text = "Set";
            this.btn_highHumi.UseVisualStyleBackColor = false;
            this.btn_highHumi.Click += new System.EventHandler(this.btn_highHumi_Click);
            // 
            // btn_lowHumi
            // 
            this.btn_lowHumi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lowHumi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowHumi.Location = new System.Drawing.Point(14, 303);
            this.btn_lowHumi.Name = "btn_lowHumi";
            this.btn_lowHumi.Size = new System.Drawing.Size(75, 36);
            this.btn_lowHumi.TabIndex = 11;
            this.btn_lowHumi.Text = "Set";
            this.btn_lowHumi.UseVisualStyleBackColor = false;
            this.btn_lowHumi.Click += new System.EventHandler(this.btn_lowHumi_Click);
            // 
            // lb_high_humi
            // 
            this.lb_high_humi.AutoSize = true;
            this.lb_high_humi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_high_humi.Location = new System.Drawing.Point(202, 238);
            this.lb_high_humi.Name = "lb_high_humi";
            this.lb_high_humi.Size = new System.Drawing.Size(52, 21);
            this.lb_high_humi.TabIndex = 10;
            this.lb_high_humi.Text = "label5";
            // 
            // txt_high_Humi
            // 
            this.txt_high_Humi.Location = new System.Drawing.Point(168, 267);
            this.txt_high_Humi.Name = "txt_high_Humi";
            this.txt_high_Humi.Size = new System.Drawing.Size(75, 29);
            this.txt_high_Humi.TabIndex = 8;
            // 
            // lb_low_humi
            // 
            this.lb_low_humi.AutoSize = true;
            this.lb_low_humi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_low_humi.Location = new System.Drawing.Point(52, 238);
            this.lb_low_humi.Name = "lb_low_humi";
            this.lb_low_humi.Size = new System.Drawing.Size(52, 21);
            this.lb_low_humi.TabIndex = 9;
            this.lb_low_humi.Text = "label4";
            // 
            // txt_low_Humi
            // 
            this.txt_low_Humi.Location = new System.Drawing.Point(14, 267);
            this.txt_low_Humi.Name = "txt_low_Humi";
            this.txt_low_Humi.Size = new System.Drawing.Size(75, 29);
            this.txt_low_Humi.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(154, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "High:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Low:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(88, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 30);
            this.label13.TabIndex = 3;
            this.label13.Text = "Humidity";
            // 
            // chart_Humi
            // 
            this.chart_Humi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_Humi.Location = new System.Drawing.Point(56, 74);
            this.chart_Humi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Humi.Name = "chart_Humi";
            this.chart_Humi.Size = new System.Drawing.Size(149, 185);
            this.chart_Humi.TabIndex = 2;
            this.chart_Humi.Text = "solidGauge2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.btn_highSoil);
            this.panel4.Controls.Add(this.btn_lowSoil);
            this.panel4.Controls.Add(this.lb_high_soil);
            this.panel4.Controls.Add(this.txt_high_Soil);
            this.panel4.Controls.Add(this.lb_low_soil);
            this.panel4.Controls.Add(this.txt_low_Soil);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.chart_Soil);
            this.panel4.Location = new System.Drawing.Point(812, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 360);
            this.panel4.TabIndex = 15;
            // 
            // btn_highSoil
            // 
            this.btn_highSoil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_highSoil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highSoil.Location = new System.Drawing.Point(168, 302);
            this.btn_highSoil.Name = "btn_highSoil";
            this.btn_highSoil.Size = new System.Drawing.Size(75, 36);
            this.btn_highSoil.TabIndex = 12;
            this.btn_highSoil.Text = "Set";
            this.btn_highSoil.UseVisualStyleBackColor = false;
            this.btn_highSoil.Click += new System.EventHandler(this.btn_highSoil_Click);
            // 
            // btn_lowSoil
            // 
            this.btn_lowSoil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lowSoil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowSoil.Location = new System.Drawing.Point(14, 303);
            this.btn_lowSoil.Name = "btn_lowSoil";
            this.btn_lowSoil.Size = new System.Drawing.Size(75, 36);
            this.btn_lowSoil.TabIndex = 11;
            this.btn_lowSoil.Text = "Set";
            this.btn_lowSoil.UseVisualStyleBackColor = false;
            this.btn_lowSoil.Click += new System.EventHandler(this.btn_lowSoil_Click);
            // 
            // lb_high_soil
            // 
            this.lb_high_soil.AutoSize = true;
            this.lb_high_soil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_high_soil.Location = new System.Drawing.Point(202, 238);
            this.lb_high_soil.Name = "lb_high_soil";
            this.lb_high_soil.Size = new System.Drawing.Size(52, 21);
            this.lb_high_soil.TabIndex = 10;
            this.lb_high_soil.Text = "label5";
            // 
            // txt_high_Soil
            // 
            this.txt_high_Soil.Location = new System.Drawing.Point(168, 267);
            this.txt_high_Soil.Name = "txt_high_Soil";
            this.txt_high_Soil.Size = new System.Drawing.Size(75, 29);
            this.txt_high_Soil.TabIndex = 8;
            // 
            // lb_low_soil
            // 
            this.lb_low_soil.AutoSize = true;
            this.lb_low_soil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_low_soil.Location = new System.Drawing.Point(52, 238);
            this.lb_low_soil.Name = "lb_low_soil";
            this.lb_low_soil.Size = new System.Drawing.Size(52, 21);
            this.lb_low_soil.TabIndex = 9;
            this.lb_low_soil.Text = "label4";
            // 
            // txt_low_Soil
            // 
            this.txt_low_Soil.Location = new System.Drawing.Point(14, 267);
            this.txt_low_Soil.Name = "txt_low_Soil";
            this.txt_low_Soil.Size = new System.Drawing.Size(75, 29);
            this.txt_low_Soil.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(154, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 21);
            this.label16.TabIndex = 6;
            this.label16.Text = "High:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 21);
            this.label17.TabIndex = 5;
            this.label17.Text = "Low:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(88, 44);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(106, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 30);
            this.label18.TabIndex = 3;
            this.label18.Text = "Soil";
            // 
            // chart_Soil
            // 
            this.chart_Soil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_Soil.Location = new System.Drawing.Point(56, 74);
            this.chart_Soil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Soil.Name = "chart_Soil";
            this.chart_Soil.Size = new System.Drawing.Size(149, 185);
            this.chart_Soil.TabIndex = 2;
            this.chart_Soil.Text = "solidGauge3";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1075, 366);
            this.panel5.TabIndex = 16;
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 629);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Control";
            this.Text = "Form_Control";
            this.Load += new System.EventHandler(this.Form_Control_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.SolidGauge chart_Light;
        private System.Windows.Forms.Timer timer_data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_high_light;
        private System.Windows.Forms.TextBox txt_low_light;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_high_light;
        private System.Windows.Forms.Label lb_low_light;
        private System.Windows.Forms.Button btn_highLight;
        private System.Windows.Forms.Button btn_lowLight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_highTemp;
        private System.Windows.Forms.Button btn_lowTemp;
        private System.Windows.Forms.Label lb_high_temp;
        private System.Windows.Forms.TextBox txt_high_Temp;
        private System.Windows.Forms.Label lb_low_temp;
        private System.Windows.Forms.TextBox txt_low_Temp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private LiveCharts.WinForms.SolidGauge chart_Temp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_highHumi;
        private System.Windows.Forms.Button btn_lowHumi;
        private System.Windows.Forms.Label lb_high_humi;
        private System.Windows.Forms.TextBox txt_high_Humi;
        private System.Windows.Forms.Label lb_low_humi;
        private System.Windows.Forms.TextBox txt_low_Humi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private LiveCharts.WinForms.SolidGauge chart_Humi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_highSoil;
        private System.Windows.Forms.Button btn_lowSoil;
        private System.Windows.Forms.Label lb_high_soil;
        private System.Windows.Forms.TextBox txt_high_Soil;
        private System.Windows.Forms.Label lb_low_soil;
        private System.Windows.Forms.TextBox txt_low_Soil;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label18;
        private LiveCharts.WinForms.SolidGauge chart_Soil;
        private System.Windows.Forms.Panel panel5;
    }
}