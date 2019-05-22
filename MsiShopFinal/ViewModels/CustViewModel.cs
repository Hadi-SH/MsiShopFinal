using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisteringUsers.ViewModels
{
    public class CustViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public Titles Titles { get; set; }
        public string TitleName { get; set; }

        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string IntrestedIn { get; set; }
        public string BestBrand { get; set; }
        public string Country { get; set; }
        public string DetailedAddress { get; set; }
        public int SpentTimeOnGaming { get; set; }
    }
}