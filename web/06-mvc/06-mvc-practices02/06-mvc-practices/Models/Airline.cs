using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_mvc_practices.Models
{
    public class Airline
    {
        public string AirlineName { get; set; }
        public int AircraftCount { get; set; }
        public bool IsLowcost { get; set; }
        public int MaximumLuggageWeight { get; set; }
    }
}
