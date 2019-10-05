using DependencyInjection.Application;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DependencyInjection.WeatherSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ForecastReader _forecastReader;

        public HomeController() => _forecastReader = ServicesLocator.ServiceLocator.GetForecastReader();

        public async Task<IActionResult> GetWeather(string query)
        {
            var result = await _forecastReader.ReadAsync(query);
            return View("Index", result);
        }

        public IActionResult Index() => View();

        public IActionResult Privacy() => View();
    }
}