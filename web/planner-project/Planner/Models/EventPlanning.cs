using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Models
{
    public class EventPlanning
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; } = DateTime.Now.AddHours(1);

        [Required]
        public string Author { get; set; } = "Gigi";
        
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public string IsValid { get; set; } = "";
    }
}
