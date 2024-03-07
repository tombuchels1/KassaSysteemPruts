﻿using System;
using System.Collections.Generic;

namespace KassaSysteemPruts
{
   public class Program
   {
       static void Main(string[] args)
       {

            // Blijf doorgaan totdat de gebruiker niet meer wil bestellen
            int currentOrderId = 1;
            bool createAnotherOrder = true;

            Console.WriteLine("Toets 1 voor order en toets 2 voor het adminpaneel en klik op enter (1)(2)");
            int continueOrder = int.Parse(Console.ReadLine());

            if (continueOrder == 1)
            {

                // Vraag de gebruiker om zijn naam in te voeren
                Console.WriteLine("\nEnter Naam:");
                string name = Console.ReadLine();
                Console.WriteLine("Hallo " + name);

                while (createAnotherOrder)
                {
                    // Vraag hoeveel producten de gebruiker wil toevoegen
                    Console.WriteLine("Hoeveel producten wil je toevoegen? ");
                    int amountOfProductsToCreate = int.Parse(Console.ReadLine());

                    // Maak een lege lijst om producten op te slaan
                    List<Product> Products = new List<Product>();

                    Order order = new Order(currentOrderId);

                    // Verhoog het huidige orderID voor de volgende order
                    currentOrderId++;


                    // For loop voor het aantal producten dat de gebruiker wil toevoegen
                    for (int i = 0; i < amountOfProductsToCreate; i++)
                    {
                        // Toon het product waarvoor gegevens moeten worden ingevuld
                        Console.WriteLine($"Vul gegevens in voor Product {i + 1}:");

                        int productId = i + 1;

                        // Vraag naar de naam van het product
                        Console.WriteLine("Wat is de naam van het product? :");
                        string productName = Console.ReadLine();

                        // Vraag naar de prijs van het product
                        Console.WriteLine("Wat is de prijs? :");
                        decimal price = decimal.Parse(Console.ReadLine());

                        // Vraag naar de beschrijving van het product
                        Console.WriteLine("Wat is de beschrijving van het product? :");
                        string productDescription = Console.ReadLine();

                        Console.WriteLine("Hoevaak wil je dit product toevoegen? :");
                        int amountofproductstoadd = int.Parse(Console.ReadLine());

                        for (int j = 0; j < amountofproductstoadd; j++)
                        {
                            // Maak een nieuw product aan
                            Product newProduct = new Product(productId, productName, price, productDescription);

                            // Voeg het product toe aan de lijst
                            Products.Add(newProduct);
                            order.AddProduct(newProduct);
                        }


                    }

                    // Toon de nieuw toegevoegde producten
                    Console.WriteLine("De toegevoegde producten zijn :");
                    foreach (Product product in Products)
                    {
                        Console.WriteLine($"ProductID: {product.ProductId}, Naam: {product.ProductName}, Prijs: {product.Price}, Beschrijving: {product.ProductDescription}");
                    }

                    // Toon de totale prijs van de order
                    Console.WriteLine($"OrderID: {order.OrderId}, Totale prijs: {order.CalculateTotalPrice()} euro");

                    // Vraag of de gebruiker nog een order wil plaatsen
                    Console.WriteLine("Wil je nog een order plaatsen? (y/n)");
                    string answer = Console.ReadLine();

                    // Als het antwoord niet "y" is, stop de loop
                    if (answer != "y")
                    {
                        createAnotherOrder = false;
                        order.GenerateBon();

                    }

                    else
                    {
                        Console.WriteLine("Work in porgress");
                        break;
                    }
                }
                
            
            }

           
           Console.WriteLine("Bedankt en totziens!");
           Console.ReadLine();
       }
   }
}
