using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MsiShopFinal.Models
{
    public class SpecialOffers
    {
        public int Id { get; set; }
        [Required]
        public string SOData { get; set; }
    }
}