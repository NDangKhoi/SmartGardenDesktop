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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden
{
    public partial class Form1_Chart : Form
    {
        public Form1_Chart()
        {
            InitializeComponent();
        }
        IFirebaseConfig icf = new FirebaseConfig()
        {
            AuthSecret = "w6Jm76dzDJj3d4g2aJ3dc6TQAYc1RhCStuW9mOHt",
            BasePath = "https://vuonthongminh-328d9-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            FirebaseResponse response = await client.GetAsync("Status/Sensor");
            DataSensor data = response.ResultAs<DataSensor>();
            #region Light
            chart_light.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), data.Light);
            if (chart_light.Series[0].Points.Count > 100)
            {
                chart_light.Series[0].Points.RemoveAt(0);
            }
            chart_light.ChartAreas[0].AxisX.Minimum = chart_light.Series[0].Points[0].XValue;
            chart_light.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(data.Light) + 10;
            #endregion
            #region Humidity
            chart_humidity.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), data.Humidity);
            if (chart_humidity.Series[0].Points.Count > 100)
            {
                chart_humidity.Series[0].Points.RemoveAt(0);
            }
            chart_humidity.ChartAreas[0].AxisX.Minimum = chart_humidity.Series[0].Points[0].XValue;
            chart_humidity.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(data.Humidity) + 10;
            #endregion
            #region Temperature
            chart_temp.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), data.Temperature);
            if (chart_temp.Series[0].Points.Count > 100)
            {
                chart_temp.Series[0].Points.RemoveAt(0);
            }
            chart_temp.ChartAreas[0].AxisX.Minimum = chart_temp.Series[0].Points[0].XValue;
            chart_temp.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(data.Temperature) + 10;
            #endregion
            #region Soil
            chart_soil.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), data.Soil);
            if (chart_soil.Series[0].Points.Count > 100)
            {
                chart_soil.Series[0].Points.RemoveAt(0);
            }
            chart_soil.ChartAreas[0].AxisX.Minimum = chart_soil.Series[0].Points[0].XValue;
            chart_soil.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(data.Soil) + 10;
            #endregion

        }

        private void Form1_Chart_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(icf);
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
    }
}
