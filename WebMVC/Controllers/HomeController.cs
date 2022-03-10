using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMVC.Models;
using ConsoleAppProject.App01;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {

        /*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if (converter.fromDistance > 0)
                converter.Calculate();

            return View(converter);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}