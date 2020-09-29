using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial1.Models
{
    public class Agreemant
    {
        public Agreemant()
        {
            AgreemantUniversities = new List<AgreemantUniversity>();
        }
        [Key]
       // [DatabaseGenerated(1,1)]
        public int Id { get; set; }


        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public bool IsAgree { get; set; }

        public ICollection<AgreemantUniversity> AgreemantUniversities { get; set; }

        [NotMapped]
        public IEnumerable<int> UniversityIds { get; set; }

        
        public DateTime SubmitDateTime { get; set; }


    }
}
