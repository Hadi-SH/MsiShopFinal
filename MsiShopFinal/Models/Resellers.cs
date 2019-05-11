using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MsiShopFinal.Models
{
    public class Resellers
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Store Name")]
        public string StoreName { get; set; }
        [Required]
        [Display(Name = "Store Phone")]
        public string StorePhone { get; set; }
        [Required]
        [Display(Name = "Store Location")]
        public string StoreLocation { get; set; }
        [Required]
        [Display(Name = "Most BuyAble Brand")]
        public string MostBuyableBrand { get; set; }
        [Required]
        [Display(Name = "Net Worth / Month")]
        public int NetWorthPerMonth { get; set; }
        [Required]
        [Display(Name = "Store Email")]
        public string StoreEmail { get; set; }
        [Required]
        public string Password { get; set; }
    }
}