﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace appFoodDelivery.Models
{
    public class StateCreateViewModel
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Select Country")]
        public int countryid { get; set; }
        
        [Required]
        public string StateName { get; set; }

 
        public Boolean isdeleted { get; set; }
         
        public Boolean isactive { get; set; }
    }
}
