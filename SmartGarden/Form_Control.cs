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
            FirebaseResponse response = await client.GetAsync("Status/Sensor");
            DataSensor data = response.ResultAs<DataSensor>();

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
        }

        
        private void Form_Control_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(icf);
            timer_data.Enabled = true;           
        }
        #region Void 
        async void showData_Limit(String path, Label lb, String typeval)
        {
            FirebaseResponse response = await client.GetAsync("System/SetValue/" + path);
            DataLimit dataLimit = response.ResultAs<DataLimit>();
            if (typeval == "LOW") lb.Text = dataLimit.LOW;
            else lb.Text = dataLimit.HIGH;
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
    }
}
