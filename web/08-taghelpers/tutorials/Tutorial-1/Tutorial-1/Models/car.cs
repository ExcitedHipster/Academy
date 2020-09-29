﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Models
{
    public class Car
    {
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [Display(Name = "Car brand")]
        public string Name { get; set; }
        [Required]
        [Range(10,500)]
        [Display(Name="Car's top speed")]
        public int MaxSpeed { get; set; }
    }
}