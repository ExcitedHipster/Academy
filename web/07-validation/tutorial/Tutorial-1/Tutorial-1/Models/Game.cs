using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Models {
    public class Game 
    {
        [Required(ErrorMessage = "Please provide a value")]
        [MaxLength(60, ErrorMessage = "Not more than 60 chars")]
        [MinLength(3, ErrorMessage = "Not less than 3 chars")]
        public string Name { get; set; }





        [Required(ErrorMessage = "Please provide a value")]
        public DateTime ReleaseDate { get; set; }




        [Required(ErrorMessage = "Please provide a value")]
        public decimal Price { get; set; }




        [Required(ErrorMessage = "Please provide a value")]
        [MaxLength(30, ErrorMessage = "Not more than 30 chars")]
        [RegularExpression("^[A-Z][a-z]*$",ErrorMessage = "Only chars allowed")]
        public string Genre { get; set; }
        


        [Required(ErrorMessage = "Please provide a value")]
        [MaxLength(5, ErrorMessage = "Not more than 5 chars")]
        [RegularExpression("^[A-Z][a-z]*$", ErrorMessage = "Only chars allowed")]
        public string Rating { get; set; }
    }
}
