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
    [Area("Registration")]
    public class RegistrationController : Controller
    { 
        
        private readonly ILogger<RegistrationController> _logger;
        private readonly IFileServices _fileService;

        public RegistrationController(ILogger<RegistrationController> logger,IFileServices fileService)
        {
            _fileService = fileService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet("Home/Create")]
        public IActionResult CreateAccount()
        {
            return View();
        }
        [HttpPost("CreateAccountPost")]
        public IActionResult CreateAccountPost(AccountInfo account)
        {
            if (ModelState.IsValid)
            {
                var random = new Random();
                string RandomPick = "abcdefghi0123456789--";
                var sbuilder = new StringBuilder();
                for (int i = 0; i < 25; i++)
                {                    
                    int randNum = random.Next(0, 21);                    
                    sbuilder.Append(RandomPick[randNum]);                     
                }

                account.ClientId = sbuilder.ToString();
                _fileService.SaveToFile(account);
                return View("Success",account);
            }

            return View();
        }
        [HttpGet("Home/Success")]
        public IActionResult Success()
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