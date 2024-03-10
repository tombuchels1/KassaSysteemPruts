using System;
using System.Collections.Generic;

namespace KassaSysteemPruts
{
    public class Order

    {
        public int OrderId { get; set; }
        private List<Product> Products { get; set; }
        public Customer Customer  { get; set; }
        public Employee Employee { get; set; }

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
        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (Product product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }

        // Functie om bon te genereren
        public void GenerateBon()
        {
            // directory om op te slaan
            string directoryPath = @"C:\Users\vaals\source\repos\KassaSysteemPruts";

            // Voeg samen DirectoryPath en Filename
            string filePath = Path.Combine(directoryPath, "Bonnetje.txt");

            // Schrijf producten naar file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Product product in Products)
                {
                    sw.WriteLine($"ProductID: {product.ProductId}, Naam: {product.ProductName}, Prijs: {product.Price}, Beschrijving: {product.ProductDescription}");
                }

                // Voeg de totale prijs toe aan het bestand
                sw.WriteLine($"OrderID: {OrderId}, Totale prijs: {CalculateTotalPrice()} euro");
                sw.WriteLine($"Datum en Tijd: {DateTime.Now}");

            }
        }


    }
}