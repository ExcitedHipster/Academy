using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial1.Models
{
    public class AgreemantUniversity
    {
        public int AgreemantId { get; set; }
        public Agreemant Agreemant { get; set; }




        public int UniversityId { get; set; }
        public University University { get; set; }
    }
}
