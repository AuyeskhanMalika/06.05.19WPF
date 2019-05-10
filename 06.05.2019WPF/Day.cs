using Newtonsoft.Json;

namespace _06._05._2019WPF
{
    public class Day
    {
        [JsonProperty("maxtemp_c")]
        public double? MaximumTemperatureInCelsius { get; set; }

        [JsonProperty("mintemp_c")]
        public double? MinimumTemperatureInCelsius { get; set; }

        [JsonProperty("maxwind_kph")]
        public double? WindSpeed { get; set; }

        [JsonProperty("avghumidity")]
        public double? AverageHumidity { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }
    }
}
