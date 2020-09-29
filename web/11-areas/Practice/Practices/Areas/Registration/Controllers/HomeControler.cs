using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practices.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Practices.Areas.Registration.Controllers
{
    [Area("Registration")]
    public class HomeControler : Controller
    {
        private readonly ILogger<HomeControler> _logger;

        public HomeControler(ILogger<HomeControler> logger)
        {
            _logger = logger;
        }

        public IActionResult Create()
        {
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
