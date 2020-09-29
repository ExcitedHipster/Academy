using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_mvc_practices.Models
{
    public class Airport
    {
        public string Name { get; set; }
        public string City { get; set; }
        public bool IsInternational { get; set; }
        public List<Airline> airlines;
    }
}
