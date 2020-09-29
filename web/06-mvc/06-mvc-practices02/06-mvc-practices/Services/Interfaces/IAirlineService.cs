using _06_mvc_practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_mvc_practices.Services.Interfaces
{
    public interface IAirlineService
    {
        IEnumerable<Airline> GetAllAirlines();

        void CreateAirline(Airline airline);
    }
}
