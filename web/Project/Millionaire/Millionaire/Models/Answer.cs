using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Models {
    public class Answer {

        
        [Required]
        [MinLength(25)]
        public string AnswerContent { get; set; }

        public bool IsRight { get; set; }

    }
}
