using Newtonsoft.Json;

namespace DependencyInjection.Infrastructure.WeatherApiModels
{
    public class Forecast
    {
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("dt")]
        public long Dt { get; set; }

        [JsonProperty("dt_txt")]
        public string DtTxt { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
        public Rain Rain { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }
    }
}