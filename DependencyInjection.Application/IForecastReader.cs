using DependencyInjection.Application.Models;
using System.Threading.Tasks;

namespace DependencyInjection.Application
{
    public interface IForecastReader
    {
        Task<CityForecast> ReadAsync(string zipCode);
    }
}