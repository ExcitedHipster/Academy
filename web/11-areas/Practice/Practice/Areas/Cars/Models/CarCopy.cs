using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class CarCopy
    {
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }
        
        [Required]
        [Range(10, 500)]
        public int  MaxSpeed { get; set; }
    }
}
