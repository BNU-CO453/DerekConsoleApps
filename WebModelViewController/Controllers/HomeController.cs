using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebModelViewController.Models;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;

namespace WebModelViewController.Controllers
{
    public class HomeController : Controller
    {
        DistanceConverter App01 = new DistanceConverter();
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Distance(DistanceConverter converter)
        {
            if (converter.fromDistance > 0)
            {
                converter.Calculate();
            }
            return View(converter);
        }

        public IActionResult Student(StudentGrades grades)
        {
            if(grades.studentMark1 > 0)
            {
                grades.updateArray();
            }
            //grades.studentMark1 = 10;
            return View(grades);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
