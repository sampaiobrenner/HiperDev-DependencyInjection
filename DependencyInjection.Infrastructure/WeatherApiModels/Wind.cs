using Newtonsoft.Json;

namespace DependencyInjection.Infrastructure.WeatherApiModels
{
    public class Wind
    {
        [JsonProperty("deg")]
        public decimal Deg { get; set; }

        [JsonProperty("speed")]
        public decimal Speed { get; set; }
    }
}