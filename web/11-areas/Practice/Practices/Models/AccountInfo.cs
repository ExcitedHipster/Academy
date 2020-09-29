using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practices.Models
{
    public class AccountInfo
    {
        public string ClientId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [RegularExpression("\\w+")]
        public string UserName { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(12)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{6,}$")]
        public string Password { get; set; }
        [Required]
        public string CodeQuestion { get; set; }
        [Required]
        [MaxLength(30)]
        public string CodeAnswear { get; set; }

        public bool isIncorrect = false;

    }
}
