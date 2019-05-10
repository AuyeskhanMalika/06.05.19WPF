using Newtonsoft.Json;
using System.Net;

namespace _06._05._2019WPF
{
    public class Service
    {
        public Weather DeserializationJson(string cityName)
        {
            string url = $"https://api.apixu.com/v1/forecast.json?key=ba05380eeb844bb08c0123209190505&days=7&q={cityName}";
            string json;

            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(url);
            }

            var information = JsonConvert.DeserializeObject<Weather>(json);

            return information;
        }
    }
}
