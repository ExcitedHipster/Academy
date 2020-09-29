using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial1.Models
{
    public class University
    {
        public University()
        {
                AgreemantUniversities = new List<AgreemantUniversity>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<AgreemantUniversity> AgreemantUniversities { get; set; }
    }
}
