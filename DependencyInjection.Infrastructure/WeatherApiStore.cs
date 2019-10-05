using DependencyInjection.Infrastructure.WeatherApiModels;
using System.Threading.Tasks;

namespace DependencyInjection.Infrastructure
{
    public class WeatherApiStore
    {
        private readonly IOpenWeatherApiClient _openWeatherApiClient;

        public WeatherApiStore(IOpenWeatherApiClient openWeatherApiClient) =>
            _openWeatherApiClient = openWeatherApiClient;

        public async Task<CityForecast> GetAsync(string query) =>
            await _openWeatherApiClient.GetDaily(query, "1173d40af2ba465d3012faf15bae207a", "metric");
    }
}