﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace appFoodDelivery.Models
{
    public class promocodeCreateViewModel
    {
        //id, promocode, promocodeusagelimit, discount, discounttype, expirydate, createddate, isdeleted, isactive
        public int id { get; set; }
        [Required(ErrorMessage = "Name is Required"), StringLength(500, MinimumLength = 3)]
        [Display(Name = "PromoCode")]
        public string promocode { get; set; }

        [Display(Name = "Promocode Usage Limit")]
        public string promocodeusagelimit { get; set; }
        [Display(Name = "Discount")]
        public string discount { get; set; }
        [Display(Name = "Discount Type")]
        public string discounttype { get; set; }



        [Display(Name = "Expiry Date")]
        public DateTime expirydate { get; set; } = DateTime.UtcNow;
        [Display(Name = "Date")]
        public DateTime createddate { get; set; } = DateTime.UtcNow;


        public Boolean isdeleted { get; set; }

        public Boolean isactive { get; set; }
    }
}
