using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    internal class ApiResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("time_last_update_utc")]
        public string Time_last_update_utc { get; set; }
        [JsonProperty("base_code")]
        public string Base_code { get; set; }
        [JsonProperty("conversion_rates")]
        public ConversionRate Conversion_rates { get; set; }
    }
}
