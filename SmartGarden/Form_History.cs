using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace SmartGarden
{
    public partial class Form_History : Form
    {
        public Form_History()
        {
            InitializeComponent();
            
        }

        private void Form_History_Load(object sender, EventArgs e)
        {
            string url = string.Empty;
            string resContent = string.Empty;
            WebRequest webRequest;
            WebResponse webResponse;
            url = "https://vuonthongminh-328d9-default-rtdb.firebaseio.com/History.json";
            webRequest = WebRequest.Create(url);
            webResponse = webRequest.GetResponse();
            resContent = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();

            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<history_Json> json_Respone = new List<history_Json>();
            var obj = jss.Deserialize<dynamic>(resContent);
            int len = obj.Length;
            for (int i = 0; i < len; i++)
            {
                var data = new history_Json
                {
                    Date = obj[i]["Date"],
                    Time = obj[i]["Time"],
                    Fan = obj[i]["Fan"],
                    Humidity = obj[i]["Humidity"],
                    Lamp = obj[i]["Lamp"],
                    Light = obj[i]["Light"],
                    Mode = obj[i]["Mode"],
                    Pump = obj[i]["Pump"],
                    Weather = obj[i]["Rain"],
                    Reset = obj[i]["Reset"],
                    Soil = obj[i]["Soil"],
                    Stepper = obj[i]["Stepper"],
                    Temperature = obj[i]["Temperature"],                
                };
                json_Respone.Add(data);           
            }
            dtgv_history.DataSource = json_Respone;
        }
    }
}
