using System;

namespace KassaSysteemPruts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Naam:");
            string Name = Console.ReadLine();
            Console.WriteLine("Hallo " + Name);

            // Nummer voor hoeveel producten hij wil toevoegen
            Console.WriteLine("Hoeveel producten wil je toevoegen? ");
            int AmountOfProductsToCreate = int.Parse(Console.ReadLine());

            // Lege lijst voor producten in op te slaan.
            List<Product> myProducts = new List<Product>();

            Order order = new Order(1);

            // For loop voor het aantal producten wat je aangegeven hebt toe te voegen
            for (int i = 0; i < AmountOfProductsToCreate; i++)

            {
                // Laat het product zien waar je de gegevens voor invult
                Console.WriteLine($"Vul gegegens in voor Product {i + 1}:");

                int productId = i + 1;

                Console.WriteLine("Wat is de naam van het product? :");
                string productName = Console.ReadLine();

                Console.WriteLine("Wat is de prijs? :");
                float price = float.Parse(Console.ReadLine());

                Console.WriteLine("Wat is de beschrijving van het product? :");
                string productDescription = Console.ReadLine();

                Product newProduct = new Product(productId, productName, price, productDescription);

                // Voeg het product toe aan de list
                myProducts.Add(newProduct);
                order.AddProduct(newProduct);

            }

            // Print de nieuwe producten die je hebt aangemaakt
            Console.WriteLine("De toegevoegde producten zijn :");
            foreach (Product product in myProducts)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(order); // Print order prijs


            Console.ReadLine(); 


        }
    }
}
