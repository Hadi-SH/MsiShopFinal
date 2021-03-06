﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MsiShopFinal.Models
{
    public class Prods
    {
        [Key]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        public string Specifications { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [Display(Name = "Buy Able Product")]
        public bool Buyable { get; set; }

        public Categorys Categorys { get; set; }
        public string CategoryName { get; set; }
    }
}