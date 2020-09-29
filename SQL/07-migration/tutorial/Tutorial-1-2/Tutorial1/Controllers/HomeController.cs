using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tutorial1.DAL;
using Tutorial1.Models;

namespace Tutorial1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AgreemantContext _context;

        public HomeController(ILogger<HomeController> logger,AgreemantContext context)
        {
            _logger = logger;
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> People()
        {
            var agreemants = await _context.Agreemants.ToListAsync();
            return View(agreemants);
        }

        public async Task<IActionResult> GetByUniversity([FromQuery]int id)
        {
            var model =( await _context.Universities.SingleOrDefaultAsync(x=>x.Id == id)).AgreemantUniversities.Select(au => au.Agreemant).Distinct().OrderBy(x=>x.SubmitDateTime);
            return View("People",model);
        }

        public async Task<IActionResult> Accept()
        {
            var universities = await _context.Universities.ToListAsync();
            ViewBag.universities = universities;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Accept(Agreemant agreemant)
        {           
            var auMap = new List<AgreemantUniversity>();
            foreach (var id in agreemant.UniversityIds)
            {
                agreemant.AgreemantUniversities.Add(new AgreemantUniversity { AgreemantId = agreemant.Id, UniversityId = id });
            }

            agreemant.SubmitDateTime = DateTime.Now;

            _context.Agreemants.Add(agreemant);
            await _context.SaveChangesAsync();

            ViewBag.name = agreemant.Name;
            return View("ThankYou");
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
