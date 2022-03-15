using CircitTask.Models;
using Newtonsoft.Json;

namespace Backend.Models
{

    public class AstronomyData
    {
        public Location Location { get; set; }
        public Astronomy Astronomy { get; set; }
    }

    public class Astronomy
    {
        public Astro Astro { get; set; }
    }

    public class Astro
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string Moonrise { get; set; }
        public string Moonset { get; set; }

        [JsonProperty("moon_phase")]
        public string MoonPhase { get; set; }
        [JsonProperty("moon_illumination")]
        public string MoonIllumination { get; set; }
    }
}
