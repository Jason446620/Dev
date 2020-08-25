using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testcoreweb.Models;

namespace testcoreweb.Controllers
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

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-CH");
            var b= Thread.CurrentThread.CurrentCulture.CultureTypes;
            ViewBag.a = ((int)(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator.Single())).ToString("X4");
            ViewBag.b = b;
            return View();
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
