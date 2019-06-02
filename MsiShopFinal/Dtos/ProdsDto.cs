using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MsiShopFinal.Dtos
{
    public class ProdsDto
    {
        [Key]
        public string SerialNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Specifications { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public bool Buyable { get; set; }

        public string CategoryName { get; set; }
    }
}