using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CircitTask.Models
{
    [JsonObject(Title = "location")]
    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public DateTime LocalTime { get; set; }

        [JsonProperty("tz_id")]
        public string TimezoneId { get; set; }

        [JsonProperty("localtime_epoch")]
        public long LocalTimeEpoch { get; set; }

    }

    public class Timezone
    {
        public Location Location { get; set; }
    }
}
