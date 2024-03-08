using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaSysteemPruts
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }
        

        // Constructor
        public Customer(string name, int phonenumber, int customerid) 
            : base(name, phonenumber)
        {
            CustomerId = customerid;
        }

    }
}
