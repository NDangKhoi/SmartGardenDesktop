
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
            this.panel_M = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.chart_Light = new LiveCharts.WinForms.SolidGauge();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_weather = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_mode = new System.Windows.Forms.Label();
            this.btn_Auto = new System.Windows.Forms.Button();
            this.pic_mode = new System.Windows.Forms.PictureBox();
            this.btn_Manual = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Pump = new System.Windows.Forms.Panel();
            this.pic_pumpON = new System.Windows.Forms.PictureBox();
            this.btn_PumpON = new System.Windows.Forms.Button();
            this.btn_PumpOFF = new System.Windows.Forms.Button();
            this.Pump = new System.Windows.Forms.Label();
            this.pic_pumpOFF = new System.Windows.Forms.PictureBox();
            this.panel_Lamp = new System.Windows.Forms.Panel();
            this.pic_LampON = new System.Windows.Forms.PictureBox();
            this.btn_LampON = new System.Windows.Forms.Button();
            this.pic_LampOFF = new System.Windows.Forms.PictureBox();
            this.btn_LampOFF = new System.Windows.Forms.Button();
            this.Lamp = new System.Windows.Forms.Label();
            this.panel_Roof = new System.Windows.Forms.Panel();
            this.pic_RoofON = new System.Windows.Forms.PictureBox();
            this.btn_RoofON = new System.Windows.Forms.Button();
            this.pic_RoofOFF = new System.Windows.Forms.PictureBox();
            this.btn_RoofOFF = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel_Fan = new System.Windows.Forms.Panel();
            this.pic_FanON = new System.Windows.Forms.PictureBox();
            this.btn_FanON = new System.Windows.Forms.Button();
            this.pic_FanOFF = new System.Windows.Forms.PictureBox();
            this.btn_FanOFF = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.timer_data = new System.Windows.Forms.Timer(this.components);
            this.panel_M.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weather)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mode)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel_Pump.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pumpON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pumpOFF)).BeginInit();
            this.panel_Lamp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LampON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LampOFF)).BeginInit();
            this.panel_Roof.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RoofON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RoofOFF)).BeginInit();
            this.panel_Fan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FanON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FanOFF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_M
            // 
            this.panel_M.AutoScroll = true;
            this.panel_M.Controls.Add(this.tableLayoutPanel1);
            this.panel_M.Controls.Add(this.tableLayoutPanel2);
            this.panel_M.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_M.Location = new System.Drawing.Point(0, 0);
            this.panel_M.Name = "panel_M";
            this.panel_M.Size = new System.Drawing.Size(1370, 742);
            this.panel_M.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1353, 353);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 351);
            this.panel1.TabIndex = 3;
            // 
            // btn_highLight
            // 
            this.btn_highLight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_highLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_highLight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highLight.Location = new System.Drawing.Point(188, 302);
            this.btn_highLight.Name = "btn_highLight";
            this.btn_highLight.Size = new System.Drawing.Size(121, 40);
            this.btn_highLight.TabIndex = 12;
            this.btn_highLight.Text = "Set";
            this.btn_highLight.UseVisualStyleBackColor = false;
            this.btn_highLight.Click += new System.EventHandler(this.btn_highLight_Click);
            // 
            // btn_lowLight
            // 
            this.btn_lowLight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lowLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lowLight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowLight.Location = new System.Drawing.Point(34, 303);
            this.btn_lowLight.Name = "btn_lowLight";
            this.btn_lowLight.Size = new System.Drawing.Size(121, 40);
            this.btn_lowLight.TabIndex = 11;
            this.btn_lowLight.Text = "Set";
            this.btn_lowLight.UseVisualStyleBackColor = false;
            this.btn_lowLight.Click += new System.EventHandler(this.btn_lowLight_Click);
            // 
            // lb_high_light
            // 
            this.lb_high_light.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_high_light.AutoSize = true;
            this.lb_high_light.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_high_light.Location = new System.Drawing.Point(235, 238);
            this.lb_high_light.Name = "lb_high_light";
            this.lb_high_light.Size = new System.Drawing.Size(0, 21);
            this.lb_high_light.TabIndex = 10;
            // 
            // txt_high_light
            // 
            this.txt_high_light.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_high_light.Location = new System.Drawing.Point(188, 267);
            this.txt_high_light.Name = "txt_high_light";
            this.txt_high_light.Size = new System.Drawing.Size(121, 29);
            this.txt_high_light.TabIndex = 8;
            // 
            // lb_low_light
            // 
            this.lb_low_light.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_low_light.AutoSize = true;
            this.lb_low_light.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_low_light.Location = new System.Drawing.Point(85, 238);
            this.lb_low_light.Name = "lb_low_light";
            this.lb_low_light.Size = new System.Drawing.Size(0, 21);
            this.lb_low_light.TabIndex = 9;
            // 
            // txt_low_light
            // 
            this.txt_low_light.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_low_light.Location = new System.Drawing.Point(34, 267);
            this.txt_low_light.Name = "txt_low_light";
            this.txt_low_light.Size = new System.Drawing.Size(121, 29);
            this.txt_low_light.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "High:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Low:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Light";
            // 
            // chart_Light
            // 
            this.chart_Light.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart_Light.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_Light.Location = new System.Drawing.Point(72, 70);
            this.chart_Light.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Light.Name = "chart_Light";
            this.chart_Light.Size = new System.Drawing.Size(206, 185);
            this.chart_Light.TabIndex = 2;
            this.chart_Light.Text = "solidGauge1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel3.Location = new System.Drawing.Point(677, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 351);
            this.panel3.TabIndex = 14;
            // 
            // btn_highHumi
            // 
            this.btn_highHumi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_highHumi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_highHumi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highHumi.Location = new System.Drawing.Point(188, 302);
            this.btn_highHumi.Name = "btn_highHumi";
            this.btn_highHumi.Size = new System.Drawing.Size(121, 40);
            this.btn_highHumi.TabIndex = 12;
            this.btn_highHumi.Text = "Set";
            this.btn_highHumi.UseVisualStyleBackColor = false;
            this.btn_highHumi.Click += new System.EventHandler(this.btn_highHumi_Click);
            // 
            // btn_lowHumi
            // 
            this.btn_lowHumi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lowHumi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lowHumi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowHumi.Location = new System.Drawing.Point(34, 303);
            this.btn_lowHumi.Name = "btn_lowHumi";
            this.btn_lowHumi.Size = new System.Drawing.Size(121, 40);
            this.btn_lowHumi.TabIndex = 11;
            this.btn_lowHumi.Text = "Set";
            this.btn_lowHumi.UseVisualStyleBackColor = false;
            this.btn_lowHumi.Click += new System.EventHandler(this.btn_lowHumi_Click);
            // 
            // lb_high_humi
            // 
            this.lb_high_humi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_high_humi.AutoSize = true;
            this.lb_high_humi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_high_humi.Location = new System.Drawing.Point(236, 238);
            this.lb_high_humi.Name = "lb_high_humi";
            this.lb_high_humi.Size = new System.Drawing.Size(0, 21);
            this.lb_high_humi.TabIndex = 10;
            // 
            // txt_high_Humi
            // 
            this.txt_high_Humi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_high_Humi.Location = new System.Drawing.Point(188, 267);
            this.txt_high_Humi.Name = "txt_high_Humi";
            this.txt_high_Humi.Size = new System.Drawing.Size(121, 29);
            this.txt_high_Humi.TabIndex = 8;
            // 
            // lb_low_humi
            // 
            this.lb_low_humi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_low_humi.AutoSize = true;
            this.lb_low_humi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_low_humi.Location = new System.Drawing.Point(86, 238);
            this.lb_low_humi.Name = "lb_low_humi";
            this.lb_low_humi.Size = new System.Drawing.Size(0, 21);
            this.lb_low_humi.TabIndex = 9;
            // 
            // txt_low_Humi
            // 
            this.txt_low_Humi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_low_Humi.Location = new System.Drawing.Point(34, 267);
            this.txt_low_Humi.Name = "txt_low_Humi";
            this.txt_low_Humi.Size = new System.Drawing.Size(121, 29);
            this.txt_low_Humi.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(185, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "High:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Low:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(101, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(124, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 30);
            this.label13.TabIndex = 3;
            this.label13.Text = "Humidity";
            // 
            // chart_Humi
            // 
            this.chart_Humi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart_Humi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_Humi.Location = new System.Drawing.Point(74, 70);
            this.chart_Humi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Humi.Name = "chart_Humi";
            this.chart_Humi.Size = new System.Drawing.Size(206, 185);
            this.chart_Humi.TabIndex = 2;
            this.chart_Humi.Text = "solidGauge2";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel2.Location = new System.Drawing.Point(339, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 351);
            this.panel2.TabIndex = 13;
            // 
            // btn_highTemp
            // 
            this.btn_highTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_highTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_highTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highTemp.Location = new System.Drawing.Point(180, 302);
            this.btn_highTemp.Name = "btn_highTemp";
            this.btn_highTemp.Size = new System.Drawing.Size(121, 40);
            this.btn_highTemp.TabIndex = 12;
            this.btn_highTemp.Text = "Set";
            this.btn_highTemp.UseVisualStyleBackColor = false;
            this.btn_highTemp.Click += new System.EventHandler(this.btn_highTemp_Click);
            // 
            // btn_lowTemp
            // 
            this.btn_lowTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lowTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lowTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowTemp.Location = new System.Drawing.Point(26, 303);
            this.btn_lowTemp.Name = "btn_lowTemp";
            this.btn_lowTemp.Size = new System.Drawing.Size(121, 40);
            this.btn_lowTemp.TabIndex = 11;
            this.btn_lowTemp.Text = "Set";
            this.btn_lowTemp.UseVisualStyleBackColor = false;
            this.btn_lowTemp.Click += new System.EventHandler(this.btn_lowTemp_Click);
            // 
            // lb_high_temp
            // 
            this.lb_high_temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_high_temp.AutoSize = true;
            this.lb_high_temp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_high_temp.Location = new System.Drawing.Point(227, 238);
            this.lb_high_temp.Name = "lb_high_temp";
            this.lb_high_temp.Size = new System.Drawing.Size(0, 21);
            this.lb_high_temp.TabIndex = 10;
            // 
            // txt_high_Temp
            // 
            this.txt_high_Temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_high_Temp.Location = new System.Drawing.Point(180, 267);
            this.txt_high_Temp.Name = "txt_high_Temp";
            this.txt_high_Temp.Size = new System.Drawing.Size(121, 29);
            this.txt_high_Temp.TabIndex = 8;
            // 
            // lb_low_temp
            // 
            this.lb_low_temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_low_temp.AutoSize = true;
            this.lb_low_temp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_low_temp.Location = new System.Drawing.Point(77, 238);
            this.lb_low_temp.Name = "lb_low_temp";
            this.lb_low_temp.Size = new System.Drawing.Size(0, 21);
            this.lb_low_temp.TabIndex = 9;
            // 
            // txt_low_Temp
            // 
            this.txt_low_Temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_low_Temp.Location = new System.Drawing.Point(26, 267);
            this.txt_low_Temp.Name = "txt_low_Temp";
            this.txt_low_Temp.Size = new System.Drawing.Size(121, 29);
            this.txt_low_Temp.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "High:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Low:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Temperature";
            // 
            // chart_Temp
            // 
            this.chart_Temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart_Temp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_Temp.Location = new System.Drawing.Point(67, 70);
            this.chart_Temp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Temp.Name = "chart_Temp";
            this.chart_Temp.Size = new System.Drawing.Size(206, 185);
            this.chart_Temp.TabIndex = 2;
            this.chart_Temp.Text = "solidGauge1";
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
            this.panel4.Location = new System.Drawing.Point(1015, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 351);
            this.panel4.TabIndex = 15;
            // 
            // btn_highSoil
            // 
            this.btn_highSoil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_highSoil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_highSoil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_highSoil.Location = new System.Drawing.Point(187, 302);
            this.btn_highSoil.Name = "btn_highSoil";
            this.btn_highSoil.Size = new System.Drawing.Size(121, 40);
            this.btn_highSoil.TabIndex = 12;
            this.btn_highSoil.Text = "Set";
            this.btn_highSoil.UseVisualStyleBackColor = false;
            this.btn_highSoil.Click += new System.EventHandler(this.btn_highSoil_Click);
            // 
            // btn_lowSoil
            // 
            this.btn_lowSoil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lowSoil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_lowSoil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lowSoil.Location = new System.Drawing.Point(33, 303);
            this.btn_lowSoil.Name = "btn_lowSoil";
            this.btn_lowSoil.Size = new System.Drawing.Size(121, 40);
            this.btn_lowSoil.TabIndex = 11;
            this.btn_lowSoil.Text = "Set";
            this.btn_lowSoil.UseVisualStyleBackColor = false;
            this.btn_lowSoil.Click += new System.EventHandler(this.btn_lowSoil_Click);
            // 
            // lb_high_soil
            // 
            this.lb_high_soil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_high_soil.AutoSize = true;
            this.lb_high_soil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_high_soil.Location = new System.Drawing.Point(228, 238);
            this.lb_high_soil.Name = "lb_high_soil";
            this.lb_high_soil.Size = new System.Drawing.Size(0, 21);
            this.lb_high_soil.TabIndex = 10;
            // 
            // txt_high_Soil
            // 
            this.txt_high_Soil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_high_Soil.Location = new System.Drawing.Point(187, 267);
            this.txt_high_Soil.Name = "txt_high_Soil";
            this.txt_high_Soil.Size = new System.Drawing.Size(121, 29);
            this.txt_high_Soil.TabIndex = 8;
            // 
            // lb_low_soil
            // 
            this.lb_low_soil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_low_soil.AutoSize = true;
            this.lb_low_soil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_low_soil.Location = new System.Drawing.Point(84, 238);
            this.lb_low_soil.Name = "lb_low_soil";
            this.lb_low_soil.Size = new System.Drawing.Size(0, 21);
            this.lb_low_soil.TabIndex = 9;
            // 
            // txt_low_Soil
            // 
            this.txt_low_Soil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_low_Soil.Location = new System.Drawing.Point(33, 267);
            this.txt_low_Soil.Name = "txt_low_Soil";
            this.txt_low_Soil.Size = new System.Drawing.Size(121, 29);
            this.txt_low_Soil.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(183, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 21);
            this.label16.TabIndex = 6;
            this.label16.Text = "High:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 21);
            this.label17.TabIndex = 5;
            this.label17.Text = "Low:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(99, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(148, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(148, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 30);
            this.label18.TabIndex = 3;
            this.label18.Text = "Soil";
            // 
            // chart_Soil
            // 
            this.chart_Soil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart_Soil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_Soil.Location = new System.Drawing.Point(73, 70);
            this.chart_Soil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Soil.Name = "chart_Soil";
            this.chart_Soil.Size = new System.Drawing.Size(206, 185);
            this.chart_Soil.TabIndex = 2;
            this.chart_Soil.Text = "solidGauge3";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 353);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1353, 392);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.pic_weather);
            this.panel6.Location = new System.Drawing.Point(1, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 388);
            this.panel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Weather";
            // 
            // pic_weather
            // 
            this.pic_weather.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_weather.Image = ((System.Drawing.Image)(resources.GetObject("pic_weather.Image")));
            this.pic_weather.Location = new System.Drawing.Point(81, 79);
            this.pic_weather.Name = "pic_weather";
            this.pic_weather.Size = new System.Drawing.Size(170, 126);
            this.pic_weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_weather.TabIndex = 17;
            this.pic_weather.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(341, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1009, 386);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.lb_mode);
            this.panel8.Controls.Add(this.btn_Auto);
            this.panel8.Controls.Add(this.pic_mode);
            this.panel8.Controls.Add(this.btn_Manual);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1009, 77);
            this.panel8.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "MODE";
            // 
            // lb_mode
            // 
            this.lb_mode.AutoSize = true;
            this.lb_mode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mode.Location = new System.Drawing.Point(238, 19);
            this.lb_mode.Name = "lb_mode";
            this.lb_mode.Size = new System.Drawing.Size(71, 32);
            this.lb_mode.TabIndex = 20;
            this.lb_mode.Text = "Auto";
            // 
            // btn_Auto
            // 
            this.btn_Auto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Auto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Auto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Auto.Location = new System.Drawing.Point(899, 15);
            this.btn_Auto.Name = "btn_Auto";
            this.btn_Auto.Size = new System.Drawing.Size(81, 40);
            this.btn_Auto.TabIndex = 22;
            this.btn_Auto.Text = "Auto";
            this.btn_Auto.UseVisualStyleBackColor = false;
            this.btn_Auto.Click += new System.EventHandler(this.btn_Auto_Click);
            // 
            // pic_mode
            // 
            this.pic_mode.Image = ((System.Drawing.Image)(resources.GetObject("pic_mode.Image")));
            this.pic_mode.Location = new System.Drawing.Point(118, 7);
            this.pic_mode.Name = "pic_mode";
            this.pic_mode.Size = new System.Drawing.Size(84, 57);
            this.pic_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mode.TabIndex = 0;
            this.pic_mode.TabStop = false;
            // 
            // btn_Manual
            // 
            this.btn_Manual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Manual.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Manual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Manual.Location = new System.Drawing.Point(899, 15);
            this.btn_Manual.Name = "btn_Manual";
            this.btn_Manual.Size = new System.Drawing.Size(81, 40);
            this.btn_Manual.TabIndex = 21;
            this.btn_Manual.Text = "Manual";
            this.btn_Manual.UseVisualStyleBackColor = false;
            this.btn_Manual.Click += new System.EventHandler(this.btn_Manual_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.panel_Pump, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel_Lamp, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel_Roof, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel_Fan, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 77);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1009, 309);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // panel_Pump
            // 
            this.panel_Pump.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Pump.BackColor = System.Drawing.Color.Gray;
            this.panel_Pump.Controls.Add(this.pic_pumpON);
            this.panel_Pump.Controls.Add(this.btn_PumpON);
            this.panel_Pump.Controls.Add(this.btn_PumpOFF);
            this.panel_Pump.Controls.Add(this.Pump);
            this.panel_Pump.Controls.Add(this.pic_pumpOFF);
            this.panel_Pump.Location = new System.Drawing.Point(757, 1);
            this.panel_Pump.Margin = new System.Windows.Forms.Padding(1);
            this.panel_Pump.Name = "panel_Pump";
            this.panel_Pump.Size = new System.Drawing.Size(251, 307);
            this.panel_Pump.TabIndex = 1;
            // 
            // pic_pumpON
            // 
            this.pic_pumpON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_pumpON.Image = ((System.Drawing.Image)(resources.GetObject("pic_pumpON.Image")));
            this.pic_pumpON.Location = new System.Drawing.Point(87, 29);
            this.pic_pumpON.Name = "pic_pumpON";
            this.pic_pumpON.Size = new System.Drawing.Size(96, 59);
            this.pic_pumpON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pumpON.TabIndex = 4;
            this.pic_pumpON.TabStop = false;
            // 
            // btn_PumpON
            // 
            this.btn_PumpON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PumpON.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_PumpON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PumpON.Location = new System.Drawing.Point(134, 159);
            this.btn_PumpON.Name = "btn_PumpON";
            this.btn_PumpON.Size = new System.Drawing.Size(79, 43);
            this.btn_PumpON.TabIndex = 3;
            this.btn_PumpON.Text = "ON";
            this.btn_PumpON.UseVisualStyleBackColor = false;
            this.btn_PumpON.Click += new System.EventHandler(this.btn_PumpON_Click);
            // 
            // btn_PumpOFF
            // 
            this.btn_PumpOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PumpOFF.BackColor = System.Drawing.Color.Salmon;
            this.btn_PumpOFF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PumpOFF.Location = new System.Drawing.Point(45, 159);
            this.btn_PumpOFF.Name = "btn_PumpOFF";
            this.btn_PumpOFF.Size = new System.Drawing.Size(79, 43);
            this.btn_PumpOFF.TabIndex = 2;
            this.btn_PumpOFF.Text = "OFF";
            this.btn_PumpOFF.UseVisualStyleBackColor = false;
            this.btn_PumpOFF.Click += new System.EventHandler(this.btn_PumpOFF_Click);
            // 
            // Pump
            // 
            this.Pump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pump.AutoSize = true;
            this.Pump.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pump.Location = new System.Drawing.Point(99, 96);
            this.Pump.Name = "Pump";
            this.Pump.Size = new System.Drawing.Size(65, 25);
            this.Pump.TabIndex = 1;
            this.Pump.Text = "Pump";
            // 
            // pic_pumpOFF
            // 
            this.pic_pumpOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_pumpOFF.Image = ((System.Drawing.Image)(resources.GetObject("pic_pumpOFF.Image")));
            this.pic_pumpOFF.Location = new System.Drawing.Point(87, 29);
            this.pic_pumpOFF.Name = "pic_pumpOFF";
            this.pic_pumpOFF.Size = new System.Drawing.Size(96, 59);
            this.pic_pumpOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pumpOFF.TabIndex = 0;
            this.pic_pumpOFF.TabStop = false;
            // 
            // panel_Lamp
            // 
            this.panel_Lamp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Lamp.BackColor = System.Drawing.Color.Gray;
            this.panel_Lamp.Controls.Add(this.pic_LampON);
            this.panel_Lamp.Controls.Add(this.btn_LampON);
            this.panel_Lamp.Controls.Add(this.pic_LampOFF);
            this.panel_Lamp.Controls.Add(this.btn_LampOFF);
            this.panel_Lamp.Controls.Add(this.Lamp);
            this.panel_Lamp.Location = new System.Drawing.Point(253, 1);
            this.panel_Lamp.Margin = new System.Windows.Forms.Padding(1);
            this.panel_Lamp.Name = "panel_Lamp";
            this.panel_Lamp.Size = new System.Drawing.Size(250, 307);
            this.panel_Lamp.TabIndex = 3;
            // 
            // pic_LampON
            // 
            this.pic_LampON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_LampON.Image = ((System.Drawing.Image)(resources.GetObject("pic_LampON.Image")));
            this.pic_LampON.Location = new System.Drawing.Point(85, 29);
            this.pic_LampON.Name = "pic_LampON";
            this.pic_LampON.Size = new System.Drawing.Size(96, 59);
            this.pic_LampON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_LampON.TabIndex = 12;
            this.pic_LampON.TabStop = false;
            // 
            // btn_LampON
            // 
            this.btn_LampON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LampON.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_LampON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LampON.Location = new System.Drawing.Point(140, 159);
            this.btn_LampON.Name = "btn_LampON";
            this.btn_LampON.Size = new System.Drawing.Size(79, 43);
            this.btn_LampON.TabIndex = 11;
            this.btn_LampON.Text = "ON";
            this.btn_LampON.UseVisualStyleBackColor = false;
            this.btn_LampON.Click += new System.EventHandler(this.btn_LampON_Click);
            // 
            // pic_LampOFF
            // 
            this.pic_LampOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_LampOFF.Image = ((System.Drawing.Image)(resources.GetObject("pic_LampOFF.Image")));
            this.pic_LampOFF.Location = new System.Drawing.Point(85, 29);
            this.pic_LampOFF.Name = "pic_LampOFF";
            this.pic_LampOFF.Size = new System.Drawing.Size(96, 59);
            this.pic_LampOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_LampOFF.TabIndex = 8;
            this.pic_LampOFF.TabStop = false;
            // 
            // btn_LampOFF
            // 
            this.btn_LampOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LampOFF.BackColor = System.Drawing.Color.Salmon;
            this.btn_LampOFF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LampOFF.Location = new System.Drawing.Point(52, 159);
            this.btn_LampOFF.Name = "btn_LampOFF";
            this.btn_LampOFF.Size = new System.Drawing.Size(79, 43);
            this.btn_LampOFF.TabIndex = 10;
            this.btn_LampOFF.Text = "OFF";
            this.btn_LampOFF.UseVisualStyleBackColor = false;
            this.btn_LampOFF.Click += new System.EventHandler(this.btn_LampOFF_Click);
            // 
            // Lamp
            // 
            this.Lamp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lamp.AutoSize = true;
            this.Lamp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lamp.Location = new System.Drawing.Point(105, 96);
            this.Lamp.Name = "Lamp";
            this.Lamp.Size = new System.Drawing.Size(61, 25);
            this.Lamp.TabIndex = 9;
            this.Lamp.Text = "Lamp";
            // 
            // panel_Roof
            // 
            this.panel_Roof.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Roof.BackColor = System.Drawing.Color.Gray;
            this.panel_Roof.Controls.Add(this.pic_RoofON);
            this.panel_Roof.Controls.Add(this.btn_RoofON);
            this.panel_Roof.Controls.Add(this.pic_RoofOFF);
            this.panel_Roof.Controls.Add(this.btn_RoofOFF);
            this.panel_Roof.Controls.Add(this.label14);
            this.panel_Roof.Location = new System.Drawing.Point(505, 1);
            this.panel_Roof.Margin = new System.Windows.Forms.Padding(1);
            this.panel_Roof.Name = "panel_Roof";
            this.panel_Roof.Size = new System.Drawing.Size(250, 307);
            this.panel_Roof.TabIndex = 2;
            // 
            // pic_RoofON
            // 
            this.pic_RoofON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_RoofON.Image = ((System.Drawing.Image)(resources.GetObject("pic_RoofON.Image")));
            this.pic_RoofON.Location = new System.Drawing.Point(82, 29);
            this.pic_RoofON.Name = "pic_RoofON";
            this.pic_RoofON.Size = new System.Drawing.Size(96, 59);
            this.pic_RoofON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_RoofON.TabIndex = 16;
            this.pic_RoofON.TabStop = false;
            // 
            // btn_RoofON
            // 
            this.btn_RoofON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RoofON.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_RoofON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RoofON.Location = new System.Drawing.Point(129, 159);
            this.btn_RoofON.Name = "btn_RoofON";
            this.btn_RoofON.Size = new System.Drawing.Size(79, 43);
            this.btn_RoofON.TabIndex = 15;
            this.btn_RoofON.Text = "ON";
            this.btn_RoofON.UseVisualStyleBackColor = false;
            this.btn_RoofON.Click += new System.EventHandler(this.btn_RoofON_Click);
            // 
            // pic_RoofOFF
            // 
            this.pic_RoofOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_RoofOFF.Image = ((System.Drawing.Image)(resources.GetObject("pic_RoofOFF.Image")));
            this.pic_RoofOFF.Location = new System.Drawing.Point(82, 29);
            this.pic_RoofOFF.Name = "pic_RoofOFF";
            this.pic_RoofOFF.Size = new System.Drawing.Size(96, 59);
            this.pic_RoofOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_RoofOFF.TabIndex = 12;
            this.pic_RoofOFF.TabStop = false;
            // 
            // btn_RoofOFF
            // 
            this.btn_RoofOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RoofOFF.BackColor = System.Drawing.Color.Salmon;
            this.btn_RoofOFF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RoofOFF.Location = new System.Drawing.Point(40, 159);
            this.btn_RoofOFF.Name = "btn_RoofOFF";
            this.btn_RoofOFF.Size = new System.Drawing.Size(79, 43);
            this.btn_RoofOFF.TabIndex = 14;
            this.btn_RoofOFF.Text = "OFF";
            this.btn_RoofOFF.UseVisualStyleBackColor = false;
            this.btn_RoofOFF.Click += new System.EventHandler(this.btn_RoofOFF_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(105, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Roof";
            // 
            // panel_Fan
            // 
            this.panel_Fan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Fan.BackColor = System.Drawing.Color.Gray;
            this.panel_Fan.Controls.Add(this.pic_FanON);
            this.panel_Fan.Controls.Add(this.btn_FanON);
            this.panel_Fan.Controls.Add(this.pic_FanOFF);
            this.panel_Fan.Controls.Add(this.btn_FanOFF);
            this.panel_Fan.Controls.Add(this.label9);
            this.panel_Fan.Location = new System.Drawing.Point(0, 1);
            this.panel_Fan.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.panel_Fan.Name = "panel_Fan";
            this.panel_Fan.Size = new System.Drawing.Size(251, 307);
            this.panel_Fan.TabIndex = 0;
            // 
            // pic_FanON
            // 
            this.pic_FanON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_FanON.Image = ((System.Drawing.Image)(resources.GetObject("pic_FanON.Image")));
            this.pic_FanON.Location = new System.Drawing.Point(77, 29);
            this.pic_FanON.Name = "pic_FanON";
            this.pic_FanON.Size = new System.Drawing.Size(96, 59);
            this.pic_FanON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_FanON.TabIndex = 8;
            this.pic_FanON.TabStop = false;
            // 
            // btn_FanON
            // 
            this.btn_FanON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FanON.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_FanON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FanON.Location = new System.Drawing.Point(131, 159);
            this.btn_FanON.Name = "btn_FanON";
            this.btn_FanON.Size = new System.Drawing.Size(79, 43);
            this.btn_FanON.TabIndex = 7;
            this.btn_FanON.Text = "ON";
            this.btn_FanON.UseVisualStyleBackColor = false;
            this.btn_FanON.Click += new System.EventHandler(this.btn_FanON_Click);
            // 
            // pic_FanOFF
            // 
            this.pic_FanOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_FanOFF.Image = ((System.Drawing.Image)(resources.GetObject("pic_FanOFF.Image")));
            this.pic_FanOFF.Location = new System.Drawing.Point(77, 29);
            this.pic_FanOFF.Name = "pic_FanOFF";
            this.pic_FanOFF.Size = new System.Drawing.Size(96, 59);
            this.pic_FanOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_FanOFF.TabIndex = 4;
            this.pic_FanOFF.TabStop = false;
            // 
            // btn_FanOFF
            // 
            this.btn_FanOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FanOFF.BackColor = System.Drawing.Color.Salmon;
            this.btn_FanOFF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FanOFF.Location = new System.Drawing.Point(42, 159);
            this.btn_FanOFF.Name = "btn_FanOFF";
            this.btn_FanOFF.Size = new System.Drawing.Size(79, 43);
            this.btn_FanOFF.TabIndex = 6;
            this.btn_FanOFF.Text = "OFF";
            this.btn_FanOFF.UseVisualStyleBackColor = false;
            this.btn_FanOFF.Click += new System.EventHandler(this.btn_FanOFF_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fan";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Rain.png");
            this.imageList2.Images.SetKeyName(1, "Sunny.png");
            this.imageList2.Images.SetKeyName(2, "Auto.png");
            this.imageList2.Images.SetKeyName(3, "Customer.png");
            this.imageList2.Images.SetKeyName(4, "Manual.png");
            this.imageList2.Images.SetKeyName(5, "Fan-OFF.png");
            this.imageList2.Images.SetKeyName(6, "Fan-ON.png");
            this.imageList2.Images.SetKeyName(7, "Lamp-OFF.png");
            this.imageList2.Images.SetKeyName(8, "Lamp-ON.png");
            this.imageList2.Images.SetKeyName(9, "Roof-OFF.png");
            this.imageList2.Images.SetKeyName(10, "Roof-ON.png");
            this.imageList2.Images.SetKeyName(11, "Pump-OFF.png");
            this.imageList2.Images.SetKeyName(12, "Pump-ON.png");
            // 
            // timer_data
            // 
            this.timer_data.Tick += new System.EventHandler(this.timer_data_Tick);
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 742);
            this.Controls.Add(this.panel_M);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Control";
            this.Text = "Form_Control";
            this.Load += new System.EventHandler(this.Form_Control_Load);
            this.panel_M.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weather)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mode)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel_Pump.ResumeLayout(false);
            this.panel_Pump.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pumpON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pumpOFF)).EndInit();
            this.panel_Lamp.ResumeLayout(false);
            this.panel_Lamp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LampON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LampOFF)).EndInit();
            this.panel_Roof.ResumeLayout(false);
            this.panel_Roof.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RoofON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RoofOFF)).EndInit();
            this.panel_Fan.ResumeLayout(false);
            this.panel_Fan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FanON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FanOFF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_M;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_highLight;
        private System.Windows.Forms.Button btn_lowLight;
        private System.Windows.Forms.Label lb_high_light;
        private System.Windows.Forms.TextBox txt_high_light;
        private System.Windows.Forms.Label lb_low_light;
        private System.Windows.Forms.TextBox txt_low_light;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.SolidGauge chart_Light;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_weather;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_mode;
        private System.Windows.Forms.Button btn_Auto;
        private System.Windows.Forms.PictureBox pic_mode;
        private System.Windows.Forms.Button btn_Manual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel_Pump;
        private System.Windows.Forms.PictureBox pic_pumpON;
        private System.Windows.Forms.Button btn_PumpON;
        private System.Windows.Forms.Button btn_PumpOFF;
        private System.Windows.Forms.Label Pump;
        private System.Windows.Forms.PictureBox pic_pumpOFF;
        private System.Windows.Forms.Panel panel_Lamp;
        private System.Windows.Forms.PictureBox pic_LampON;
        private System.Windows.Forms.Button btn_LampON;
        private System.Windows.Forms.PictureBox pic_LampOFF;
        private System.Windows.Forms.Button btn_LampOFF;
        private System.Windows.Forms.Label Lamp;
        private System.Windows.Forms.Panel panel_Roof;
        private System.Windows.Forms.PictureBox pic_RoofON;
        private System.Windows.Forms.Button btn_RoofON;
        private System.Windows.Forms.PictureBox pic_RoofOFF;
        private System.Windows.Forms.Button btn_RoofOFF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel_Fan;
        private System.Windows.Forms.PictureBox pic_FanON;
        private System.Windows.Forms.Button btn_FanON;
        private System.Windows.Forms.PictureBox pic_FanOFF;
        private System.Windows.Forms.Button btn_FanOFF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Timer timer_data;
    }
}