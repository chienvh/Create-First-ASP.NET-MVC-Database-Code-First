using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstDatabaseCodeFirstMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}