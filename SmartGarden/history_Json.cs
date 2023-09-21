using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartGarden
{
    class history_Json
    {
        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("Time")]
        public string Time { get; set; }

        [JsonProperty("Mode")]
        public string Mode { get; set; }

        [JsonProperty("Fan")]
        public string Fan { get; set; }

        [JsonProperty("Lamp")]
        public string Lamp { get; set; }

        [JsonProperty("Pump")]
        public string Pump { get; set; }

        [JsonProperty("Stepper")]
        public string Stepper { get; set; }

        [JsonProperty("Humidity")]
        public string Humidity { get; set; }

        [JsonProperty("Light")]
        public string Light { get; set; }

        [JsonProperty("Rain")]
        public string Weather { get; set; }  

        [JsonProperty("Soil")]
        public string Soil { get; set; }

        [JsonProperty("Temperature")]
        public string Temperature { get; set; }

        [JsonProperty("Reset")]
        public bool Reset { get; set; }

    }
}
