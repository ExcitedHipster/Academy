using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Models
{
    public class Company
    {    
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public List<Employee> Emploies { get; set; }
    }
}
