using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lawsite.Models;

namespace lawsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

         public IActionResult About()
        {
            return View();
        }

         public IActionResult Facilities()
        {
            return View();
        }

         public IActionResult Courses()
        {
            return View();
        }
         public IActionResult Staff()
        {
            return View();
        }

      [HttpGet]
         public IActionResult Journal()
        {
            return View(new Journal());
        }

        [HttpPost]
         public IActionResult Journal(Journal journal)
        {
            return RedirectToAction("Index");
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
