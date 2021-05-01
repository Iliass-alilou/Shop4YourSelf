﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop4Yourself.Models
{
    public class CategoriesModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string Name { get; set; }


    }
}
