using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MsiShopFinal.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        [Required]
        public string Phone { get; set; }
        [Display(Name = "Intrested In")]
        public string IntrestedIn { get; set; }
        [Display(Name = "Best Brand")]
        public string BestBrand { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Detailed Address")]
        public string DetailedAddress { get; set; }
        public Titles Titles { get; set; }
        public string TitleName { get; set; }
        [Display(Name = "Spent Time On Gaming")]
        public int SpentTimeOnGaming { get; set; }
    }

    public class Titles
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}