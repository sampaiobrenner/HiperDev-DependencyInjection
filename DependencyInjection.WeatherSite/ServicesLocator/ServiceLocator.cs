using DependencyInjection.Application;
using DependencyInjection.Infrastructure;
using Refit;

namespace DependencyInjection.WeatherSite.ServicesLocator
{
    public class ServiceLocator
    {
        public static ForecastReader GetForecastReader() => new ForecastReader(GetWeatherApiStore());

        private static IOpenWeatherApiClient GetOpenWeatherApiClient() =>
                    RestService.For<IOpenWeatherApiClient>("https://api.openweathermap.org/data/2.5");

        private static WeatherApiStore GetWeatherApiStore() => new WeatherApiStore(GetOpenWeatherApiClient());
    }
}