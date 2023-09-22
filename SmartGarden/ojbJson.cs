using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SmartGarden
{
    class ojbJson
    {
        JavaScriptSerializer jss = new JavaScriptSerializer();
        List<history_Json> json_Respone = new List<history_Json>();
        WebRequest webRequest;
        WebResponse webResponse;
        string resContent = string.Empty;
        string url = string.Empty;
        public int obj;
        public void getData()
        {
            url = "https://vuonthongminh-328d9-default-rtdb.firebaseio.com/History.json";
            webRequest = WebRequest.Create(url);
            webResponse = webRequest.GetResponse();
            resContent = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            obj = jss.Deserialize<dynamic>(resContent);
        }
        
    }
}
