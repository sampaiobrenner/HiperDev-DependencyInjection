using Newtonsoft.Json;

namespace DependencyInjection.Infrastructure.WeatherApiModels
{
    public class Weather
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }
    }
}