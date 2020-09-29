using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tutorials.Data;
using Tutorials.Services;

namespace Tutorials.Controllers
{
    
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ISecurityService _securityService;

        public AccountController(AppDbContext context,ISecurityService securityService)
        {
            _context = context;
            _securityService = securityService;
        }
        [HttpGet]
        [Route("Token")]
        public IActionResult Token()
        {
            return View();
        }

        [HttpPost]
        [Route("Token")]
        public IActionResult Token(string username, string password)
        {
            var user = _context.Users.SingleOrDefault(x => x.UserName == username);

            if (user != null && _securityService.VerifyUserPassword(user, password))
            {
                var result = _securityService.IssueJwtToken(user);

                System.IO.File.WriteAllText("token.txt", result.Token);

                return View("Success", result.Token);
            }
            return BadRequest();
        }
    }
}