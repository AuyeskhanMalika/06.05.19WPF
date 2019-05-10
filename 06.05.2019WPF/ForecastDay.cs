using Newtonsoft.Json;
using System;

namespace _06._05._2019WPF
{
    public class ForecastDay
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }
    }
}
