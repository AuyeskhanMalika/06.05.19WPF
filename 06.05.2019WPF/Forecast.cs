using Newtonsoft.Json;
using System.Collections.Generic;

namespace _06._05._2019WPF
{
    public class Forecast
    {
        [JsonProperty("forecastday")]
        public IList<ForecastDay> ForecastDay { get; set; }
    }
}