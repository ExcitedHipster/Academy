using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_mvc_practices.Models;

namespace _06_mvc_practices.Services
{
    public class AirportService : IAirportService
    {
        private List<Airport> _airports = new List<Airport>
            {
            };
        public void CreateAirport(Airport airport)
        {
            _airports.Add(airport);
        }
        public IEnumerable<Airport> GetAllAirports()
        {
            return _airports;
        }
    }
}