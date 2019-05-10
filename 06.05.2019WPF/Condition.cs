using Newtonsoft.Json;

namespace _06._05._2019WPF
{
    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
