using Newtonsoft.Json;

namespace _06._05._2019WPF
{
    public class Weather
    {
        [JsonProperty("forecast")]
        public Forecast Forecast { get; set; }
    }
}