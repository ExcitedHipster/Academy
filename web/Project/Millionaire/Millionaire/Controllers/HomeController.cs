using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Millionaire.Models;
using Millionaire.Services.Implementations;

namespace Millionaire.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index()
        { 
            GameController.id = 1;
            GameController.CurrentTips = new Tip { FiftyFifty = true, Friend = true, Audience = true };
            GameController.TipsIndicator = new Tip { FiftyFifty = false, Friend = false, Audience = false };
            GameController.id = 1; 
            GameController.ind = 1;
            QuestionRepository.readQuestions();
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
