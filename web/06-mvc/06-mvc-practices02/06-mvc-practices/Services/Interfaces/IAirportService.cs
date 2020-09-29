using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_mvc_practices.Models;

namespace _06_mvc_practices.Services
{
    public interface IAirportService
    {
        IEnumerable<Airport> GetAllAirports();

        void CreateAirport(Airport airport);
    }
}
