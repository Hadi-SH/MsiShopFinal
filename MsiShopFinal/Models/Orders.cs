using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MsiShopFinal.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public Customers Customers { get; set; }
        public int CustomerId { get; set; }
        public Resellers Resellers { get; set; }
        public int ResellerId { get; set; }
    }
}