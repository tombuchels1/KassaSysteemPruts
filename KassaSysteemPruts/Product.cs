using System;
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
        public float Price { get; set; }
        public string ProductDescription { get; set; }


        // Constructor
        public Product(int productid, string name, float price, string productdescription)
        {
            ProductId = productid;
            ProductName = name;
            Price = price;
            ProductDescription = productdescription;

        }



    }

   
    
}
