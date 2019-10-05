using DependencyInjection.Application.Models;
using Serilog;
using System.Threading.Tasks;

namespace DependencyInjection.Application
{
    public class ForecastLogDecoretor : IForecastReader
    {
        private readonly IForecastReader _forecastReader;
        private readonly ILogger _logger;

        public ForecastLogDecoretor(ILogger logger, IForecastReader forecastReader)
        {
            _logger = logger;
            _forecastReader = forecastReader;
        }

        public async Task<CityForecast> ReadAsync(string zipCode)
        {
            _logger.Information($"ZipCode {zipCode}");

            return await _forecastReader.ReadAsync(zipCode);
        }
    }
}