using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Models {
    public class Question {
        public int Id { get; set; }

        [Required]
        [MinLength(25)]
        public string QuestionContent { get; set; }

        public string suggestion { get; set; } = null;
        public string TakeMoney { get; set; } = "";

        public List<Answer> Answers { get; set; } = new List<Answer>(4);
    }
}
