using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MsiShopFinal.Models
{
    public class NOrders
    {
        public int Id { get; set; }
        public Customers Customers { get; set; }
        public int CustomerId { get; set; }
        public Resellers Resellers { get; set; }
        public int ResellerId { get; set; }
        public Prods Prods { get; set; }
        public string ProdName { get; set; }
    }
}