using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MsiShopFinal.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string NTitle { get; set; }
        [Required]
        [Display(Name = "Data")]
        public string NData { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}