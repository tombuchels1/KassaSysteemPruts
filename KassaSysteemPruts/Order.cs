using System;
using System.Collections.Generic;

namespace KassaSysteemPruts
{
    public class Order
    {
        public int OrderId { get; }
        private List<Product> Products { get; }

        DateTime OrderDate { get; }

        public Order(int orderId)
        {
            OrderId = orderId;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Functie om totaal prijs uit te rekenen
        public float CalculateTotalPrice()
        {
            float totalPrice = 0;
            foreach (Product product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }


    }
}