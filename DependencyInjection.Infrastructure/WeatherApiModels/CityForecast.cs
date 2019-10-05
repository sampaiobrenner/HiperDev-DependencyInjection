using Newtonsoft.Json;

namespace DependencyInjection.Infrastructure.WeatherApiModels
{
    public class CityForecast
    {
        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("cnt")]
        public long Cnt { get; set; }

        [JsonProperty("cod")]
        public string Cod { get; set; }

        [JsonProperty("list")]
        public Forecast[] List { get; set; }

        [JsonProperty("message")]
        public decimal Message { get; set; }
    }
}