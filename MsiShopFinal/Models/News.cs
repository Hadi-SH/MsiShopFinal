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
        public string NData { get; set; }
    }
}