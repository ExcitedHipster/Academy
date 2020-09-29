using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_mvc_practices.Models;
using _06_mvc_practices.Services;
using _06_mvc_practices.Services.Interfaces;

namespace _06_mvc_practices.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAirportService _airportService;

        public HomeController(IAirportService airportService)
        {
            _airportService = airportService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Airport()
        {
            var airports = _airportService.GetAllAirports();
            return View(airports);
        }

        [HttpPost("CreateContactPost")]
        public IActionResult CreateContactPost(string name,string city, bool isInternational)
        {
            var newAirport = new Airport() { Name = name, City = city, IsInternational = isInternational };
            _airportService.CreateAirport(newAirport);

            var airportList = _airportService.GetAllAirports();

    

            return View("Airport", airportList);
        }
    }
}
