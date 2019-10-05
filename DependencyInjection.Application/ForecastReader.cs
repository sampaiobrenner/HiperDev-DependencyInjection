using DependencyInjection.Application.Models;
using DependencyInjection.Infrastructure;
using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Application
{
    public class ForecastReader : IForecastReader
    {
        private readonly ILogger _logger;
        private readonly WeatherApiStore _weatherApiStore;

        public ForecastReader(WeatherApiStore weatherApiStore, ILogger logger)
        {
            _weatherApiStore = weatherApiStore;
            _logger = logger;
        }

        public async Task<CityForecast> ReadAsync(string zipCode)
        {
            try
            {
                var result = await _weatherApiStore.GetAsync(zipCode);

                return new CityForecast
                {
                    CityId = result.City.Id,
                    CityName = result.City.Name,
                    Forecasts = result.List.Select(x =>
                        new Forecast
                        {
                            Date = DateTime.Parse(x.DtTxt),
                            MaxTemperature = x.Main.TempMax,
                            MinTemperature = x.Main.TempMin,
                            WeatherCondition = x.Weather[0].Description
                        }).ToList()
                };
            }
            catch (Exception e)
            {
                _logger.Error($"Ocorreu um erro... - {e.Message}");
                return new CityForecast();
            }
        }
    }
}