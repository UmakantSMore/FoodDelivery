﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace appFoodDelivery.Models
{
    public class MenumasterCreateViewModel
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Select Cusine")]
        public int productcuisineid { get; set; }

        [Required]
        [Display(Name = "Menu Name")]
        public string name { get; set; }
        public Boolean isdeleted { get; set; }

        public Boolean isactive { get; set; }
        [Display(Name = "Photo")]
        public IFormFile img { get; set; }
    }
}
