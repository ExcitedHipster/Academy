using Microsoft.AspNetCore.Mvc;
using Millionaire.Filters;
using Millionaire.Models;
using Millionaire.Services.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Controllers {
    public class LoginController : Controller {

        private readonly IAuthService _authService;
        private readonly ILogger _logger;
        public LoginController(IAuthService authService) {
            _authService = authService;
            _logger = LogManager.GetCurrentClassLogger();
        }
        // GET: Login
        public ActionResult Index() {
            _logger.Info("Index was invoked");
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(User user) {
            if (ModelState.IsValid) {
                if (_authService.IsUserValid(user, out string token)) {
                    _logger.Info("Valid Login");
                    Response.Cookies.Append(constants.TokenKey, token);
                    return Redirect(Url.Action("Index", "Question"));
                }
            }

            _logger.Info("Invalid Login");
            return View("Login");
        }
    }
}
