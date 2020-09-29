using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Position position { get; set; } = new Position { Name = "freelancer", Salary = 1242345 };
    }
}
