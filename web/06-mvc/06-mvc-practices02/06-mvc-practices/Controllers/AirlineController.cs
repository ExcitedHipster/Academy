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
    public class AirlineController : Controller
    {

        private readonly IAirlineService _airlineService;
      

        public AirlineController(IAirlineService airlineService)
        {
            _airlineService = airlineService;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Airline()
        {
            var airlines = _airlineService.GetAllAirlines();
            return View(airlines);
        }

        [HttpPost("CreateContactPost")]
        public IActionResult CreateContactPost(string airlineName, int aircraftCount, bool isLowcost, int maximumLuggageWeight)
        {
            var newAirline = new Airline() { AirlineName = airlineName, AircraftCount = aircraftCount, IsLowcost = isLowcost, MaximumLuggageWeight = maximumLuggageWeight };
            _airlineService.CreateAirline(newAirline);

            var airlineList = _airlineService.GetAllAirlines();

           

            return View("Airline", airlineList);
        }
    }
}
