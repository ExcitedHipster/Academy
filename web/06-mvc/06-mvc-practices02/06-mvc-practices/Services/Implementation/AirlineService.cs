using _06_mvc_practices.Models;
using _06_mvc_practices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_mvc_practices.Services.Implementation
{
    public class AirlineService : IAirlineService
    {
        private List<Airline> _airlines = new List<Airline>
        {
        };

        public void CreateAirline(Airline airline)
        {

            _airlines.Add(airline);
        }

        public IEnumerable<Airline> GetAllAirlines()
        {
            return _airlines;
        }
    }
}
