using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden
{
    public partial class Form_Control : Form
    {
        
        public Form_Control()
        {
            InitializeComponent();
        }
        IFirebaseConfig icf = new FirebaseConfig()
        {
            AuthSecret = "w6Jm76dzDJj3d4g2aJ3dc6TQAYc1RhCStuW9mOHt",
            BasePath = "https://vuonthongminh-328d9-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private async void timer_data_Tick(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Status/Sensor");
                DataSensor data = response.ResultAs<DataSensor>();
                #region Sensor
                #region Light
                chart_Light.From = 0;
                chart_Light.To = 1000;
                chart_Light.Value = double.Parse(data.Light);
                showData_Limit("Light", lb_low_light, "LOW");
                showData_Limit("Light", lb_high_light, "HIGH");
                #endregion
                #region Temp
                chart_Temp.From = 0;
                chart_Temp.To = 50;
                chart_Temp.Value = double.Parse(data.Temperature);
                showData_Limit("Temp", lb_low_temp, "LOW");
                showData_Limit("Temp", lb_high_temp, "HIGH");
                #endregion
                #region Humidity 
                chart_Humi.From = 0;
                chart_Humi.To = 100;
                chart_Humi.Value = double.Parse(data.Humidity);
                showData_Limit("Humidity", lb_low_humi, "LOW");
                showData_Limit("Humidity", lb_high_humi, "HIGH");
                #endregion
                #region Soil 
                chart_Soil.From = 0;
                chart_Soil.To = 100;
                chart_Soil.Value = double.Parse(data.Soil);
                showData_Limit("Soil", lb_low_soil, "LOW");
                showData_Limit("Soil", lb_high_soil, "HIGH");
                #endregion
                #endregion

                FirebaseResponse device = await client.GetAsync("Status/Device");
                DataDevice data_dev = device.ResultAs<DataDevice>();
                var mode = await client.GetAsync("Status");
                ModeSys modeSys = mode.ResultAs<ModeSys>();
                if (imageList2.Images.Count > 0)
                {
                    #region Weather
                    if (data.Rain == "Rainy")
                    {
                        pic_weather.Image = imageList2.Images[0];

                    }
                    else
                    {
                        pic_weather.Image = imageList2.Images[1];
                    }
                    #endregion
                    #region Mode
                    if (modeSys.Mode == "Customer")
                    {
                        pic_mode.Image = imageList2.Images[3];
                        lb_mode.Text = "Customer";
                        btn_Auto.Hide();
                        btn_Manual.Hide();
                        background_panelE();
                    }
                    else if (modeSys.Mode == "Auto")
                    {
                        pic_mode.Image = imageList2.Images[2];
                        lb_mode.Text = "Auto";
                        btn_Manual.Show();
                        btn_Auto.Hide();
                        background_panelE();
                    }
                    else
                    {
                        pic_mode.Image = imageList2.Images[4];
                        lb_mode.Text = "Manual";
                        btn_Auto.Show();
                        btn_Manual.Hide();
                        background_panelD();
                    }
                    #endregion
                    #region Device
                    if (data_dev.Fan == "ON")
                    {
                        pic_FanOFF.Hide();
                        pic_FanON.Show();
                        panel_Fan.BackColor = Color.LightGray;
                    }
                    else
                    {
                        pic_FanOFF.Show();
                        pic_FanON.Hide();
                        panel_Fan.BackColor = Color.Gray;
                    }
                    if (data_dev.Lamp == "ON")
                    {
                        pic_LampOFF.Hide();
                        pic_LampON.Show();
                        panel_Lamp.BackColor = Color.LightGray;
                    }
                    else
                    {
                        pic_LampOFF.Show();
                        pic_LampON.Hide();
                        panel_Lamp.BackColor = Color.Gray;
                    }
                    if (data_dev.Pump == "ON")
                    {
                        pic_pumpOFF.Hide();
                        pic_pumpON.Show();
                        panel_Pump.BackColor = Color.LightGray;
                    }
                    else
                    {
                        pic_pumpOFF.Show();
                        pic_pumpON.Hide();
                        panel_Pump.BackColor = Color.Gray;
                    }
                    if (data_dev.Stepper == "CLOSE")
                    {
                        pic_RoofOFF.Hide();
                        pic_RoofON.Show();
                        panel_Roof.BackColor = Color.LightGray;
                    }
                    else
                    {
                        pic_RoofOFF.Show();
                        pic_RoofON.Hide();
                        panel_Roof.BackColor = Color.Gray;
                    }
                    #endregion
                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }
        }
       
     
        private void Form_Control_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(icf);
            timer_data.Enabled = true;           
        }
        #region Void 
        void background_panelE()
        {
            
            btn_FanOFF.Hide();
            btn_FanON.Hide();
            btn_LampOFF.Hide();
            btn_LampON.Hide();
            btn_PumpOFF.Hide();
            btn_PumpON.Hide();
            btn_RoofOFF.Hide();
            btn_RoofON.Hide();
        }
        void background_panelD()
        {
            
            btn_FanOFF.Show();
            btn_FanON.Show();
            btn_LampOFF.Show();
            btn_LampON.Show();
            btn_PumpOFF.Show();
            btn_PumpON.Show();
            btn_RoofOFF.Show();
            btn_RoofON.Show();
        }
        async void showData_Limit(String path, Label lb, String typeval)
        {            
            try
            {
                FirebaseResponse response = await client.GetAsync("System/SetValue/" + path);
                DataLimit dataLimit = response.ResultAs<DataLimit>();
                if (typeval == "LOW") lb.Text = dataLimit.LOW;
                else lb.Text = dataLimit.HIGH;
            }
            catch
            {
                return;
            }
        }
        async void send_Limit(String path, TextBox txtLOW,TextBox txtHIGH ,String typeval,Label lb, double limitVal)
        {
            
            string valLOW = txtLOW.Text;
            string valHIGH = txtHIGH.Text;
            
            if (typeval == "LOW")
            {
                if(double.TryParse(valLOW, out double Result))
                {
                    if (valLOW != "" && double.Parse(valLOW) >= 0)
                    {
                        if (double.Parse(valLOW) <= limitVal)
                        {

                            if (double.Parse(valLOW) >= double.Parse(lb.Text))
                            {
                                MessageBox.Show("Giá trị mức thấp không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                SetResponse dataC = await client.SetAsync("System/SetValue/" + path, valLOW);
                                MessageBox.Show("Cài đặt giá trị mức thấp thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Giá trị vượt ngưỡng giới hạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá trị mức thấp không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị mức thấp không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (double.TryParse(valHIGH, out double Result))
                {
                    if (valHIGH != "" && double.Parse(valHIGH) >= 0)
                    {
                        if (double.Parse(valHIGH) <= limitVal)
                        {
                            if (double.Parse(valHIGH) <= double.Parse(lb.Text))
                            {
                                MessageBox.Show("Giá trị mức cao không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                SetResponse dataC = await client.SetAsync("System/SetValue/" + path, valHIGH);
                                MessageBox.Show("Cài đặt giá trị mức cao thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Giá trị vượt ngưỡng giới hạn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá trị mức cao không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị mức cao không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            txtLOW.Text = "";
            txtHIGH.Text = "";


        }
        #endregion

        #region Button Send Data Limit
        private void btn_lowLight_Click(object sender, EventArgs e)
        {
            send_Limit("Light/LOW", txt_low_light, txt_high_light, "LOW", lb_high_light, 1000);
        }

        private void btn_highLight_Click(object sender, EventArgs e)
        {
            send_Limit("Light/HIGH", txt_low_light, txt_high_light, "HIGH", lb_low_light, 1000);
        }

        private void btn_lowTemp_Click(object sender, EventArgs e)
        {
            send_Limit("Temp/LOW", txt_low_Temp, txt_high_Temp, "LOW", lb_high_temp, 50);
        }

        private void btn_highTemp_Click(object sender, EventArgs e)
        {
            send_Limit("Temp/HIGH", txt_low_Temp, txt_high_Temp, "HIGH", lb_low_temp, 50);
        }

        private void btn_lowHumi_Click(object sender, EventArgs e)
        {
            send_Limit("Humidity/LOW", txt_low_Humi, txt_high_Humi, "LOW", lb_high_humi, 100);
        }

        private void btn_highHumi_Click(object sender, EventArgs e)
        {
            send_Limit("Humidity/HIGH", txt_low_Humi, txt_high_Humi, "HIGH", lb_low_humi, 100);
        }

        private void btn_lowSoil_Click(object sender, EventArgs e)
        {
            send_Limit("Soil/LOW", txt_low_Soil, txt_high_Soil, "LOW", lb_high_soil, 100);
        }

        private void btn_highSoil_Click(object sender, EventArgs e)
        {
            send_Limit("Soil/HIGH", txt_low_Soil, txt_high_Soil, "HIGH", lb_low_soil, 100);
        }
      
        #endregion

        #region Button Control
        private async void btn_Auto_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Mode", "Auto");
        }

        private async void btn_Manual_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Mode", "Manual");
        }            

        private async void btn_FanOFF_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Manual/Fan", "OFF");
        }

        private async void btn_FanON_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Manual/Fan", "ON");
        }

        private async void btn_LampOFF_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Manual/Lamp", "OFF");
        }

        private async void btn_LampON_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Manual/Lamp", "ON");
        }

        private async void btn_RoofOFF_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Manual/Stepper", "OFF");
        }

        private async void btn_RoofON_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Manual/Stepper", "ON");
        }

        private async void btn_PumpOFF_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Manual/Pump", "OFF");
        }

        private async void btn_PumpON_Click(object sender, EventArgs e)
        {
            SetResponse dataC = await client.SetAsync("System/Manual/Pump", "ON");
        }






        #endregion

       
    }
}
