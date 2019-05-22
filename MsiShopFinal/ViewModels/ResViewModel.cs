using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisteringUsers.ViewModels
{
    public class ResViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Store Email")]
        public string StoreEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Store Name")]
        public string StoreName { get; set; }
        [Required]
        [Display(Name = "Store Phone")]
        public string StorePhone { get; set; }
        [Required]
        [Display(Name = "Store Country")]
        public string StoreCountry { get; set; }
        [Required]
        [Display(Name = "Store Location")]
        public string StoreLocation { get; set; }
        [Display(Name = "Most BuyAble Brand")]
        public string MostBuyableBrand { get; set; }
        [Required]
        [Display(Name = "Net Worth / Month")]
        public int NetWorthPerMonth { get; set; }
    }
}