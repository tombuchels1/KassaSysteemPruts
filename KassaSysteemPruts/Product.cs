﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaSysteemPruts
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }


        // Constructor
        public Product(int productid, string name, decimal price, string productdescription)
        {
            ProductId = productid;
            ProductName = name;
            Price = price;
            ProductDescription = productdescription;

        }



    }

   
    
}
