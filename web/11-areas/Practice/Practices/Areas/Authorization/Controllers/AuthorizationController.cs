using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practices.Models;
using Practices.Services;

namespace Practices.Controllers
{
    [Area("Authorization")]
    public class AuthorizationController : Controller
    {
        private readonly ILogger<AuthorizationController> _logger;
        private readonly IFileServices _fileService;

        public AuthorizationController(ILogger<AuthorizationController> logger,IFileServices fileService)
        {
            _fileService = fileService;
            _logger = logger;
        }

        [HttpGet("Home/Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("Home/LoginPost")]
        public IActionResult Login(AccountInfo account)
        {
            string FileContents = _fileService.GetFile();

            if (FileContents.Contains($"UserName: {account.UserName}") && FileContents.Contains($"Password: {account.Password}"))
            {
                return View("Welcome",account);
            }

            return View("LoginError");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}