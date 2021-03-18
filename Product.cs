using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStateMgtDemo.Models
{
    public class Product
    {
        public int Prodid { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int Qty { get; set; }
    }
}