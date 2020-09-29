using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLog;
using Planner.Helpers;
using Planner.Models;
using Planner.Services.Interfaces;

namespace Planner.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthService _authService;
        private readonly ILogger _logger;
        private static int id = 1;
        public LoginController(IAuthService authService)
        {
            _authService = authService;
            _logger = LogManager.GetCurrentClassLogger();
            _logger.Info("Logger was injected into Login Controller");

        }

        public ActionResult Index()
        {
            _logger.Info("Index action was provoked");

            return View();
        }

        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                if (_authService.IsUserValid(user, out string token))
                {
                    user.valid = "";
                    _logger.Info("Valid user");
                    Response.Cookies.Append(Constants.TokenKey, token);
                    return Redirect(Url.Action("Index", "Login"));
                }
            }

            if(id!=1)user.valid = "Invalid Login or Password! try again!";
            id++;
            _logger.Error("Invalid user");
            return View(user);
            
        }
    }
}