using System;
using System.Collections.Generic;

namespace KassaSysteemPruts
{
    public class Program
    {
        static void Main(string[] args)
        {
            //StartProgram: niet beste oplossing
            Console.WriteLine("Welkom bij het kassasysteem");
            Console.WriteLine("Toets 1 voor order te maken, toets 2 voor het adminpaneel en 3 om te stoppen. (1)(2)(3)");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                // Vraag de gebruiker om zijn naam in te voeren
                Console.WriteLine("\nEnter Naam:");
                string name = Console.ReadLine();
                Console.WriteLine("Hallo " + name);

                //zet currentOrderId naar 1 voor te tellen
                int currentOrderId = 1;

                // Voor while loop van createAnotherOrder
                bool createAnotherOrder = true;

                while (createAnotherOrder)
                {
                    List<Product> Products = new List<Product>();
                    Order order = new Order(currentOrderId);
                    currentOrderId++;
                    
                    bool addAnotherProduct = true;
                    //ProductIdCounter = 1 voor bijhouden van productID
                    int productIdCounter = 1;

                    while (addAnotherProduct)
                    {
                        // Vraag gegevens in voor het product
                        Console.WriteLine("Vul gegevens in voor het product:");

                        int productId = productIdCounter++;

                        // Vraag naar de naam van het product
                        Console.WriteLine("Wat is de naam van het product? :");
                        string productName = Console.ReadLine();

                        // Vraag naar de prijs van het product
                        Console.WriteLine("Wat is de prijs? :");
                        decimal price = decimal.Parse(Console.ReadLine());

                        // Vraag naar de beschrijving van het product
                        Console.WriteLine("Wat is de beschrijving van het product? :");
                        string productDescription = Console.ReadLine();

                        // Vraag hoe vaak het product toegevoegd moet worden
                        Console.WriteLine("Hoe vaak wil je dit product toevoegen? :");
                        int amountToAdd = int.Parse(Console.ReadLine());

                        for (int i = 0; i < amountToAdd; i++)
                        {
                            // Maak een nieuw product aan
                            Product newProduct = new Product(productId, productName, price, productDescription);

                            // Voeg het product toe aan de lijst
                            Products.Add(newProduct);
                            order.AddProduct(newProduct);
                        }

                        // Vraag of de gebruiker nog een product wil toevoegen
                        Console.WriteLine("Wil je nog een product toevoegen? (y/n)");
                        string answeraddAnotherProduct = Console.ReadLine();

                        // Als het antwoord niet "y" is, stop de binnenste loop
                        if (answeraddAnotherProduct != "y")
                        {
                            addAnotherProduct = false;
                        }
                    }

                    // Toon de toegevoegde producten
                    Console.WriteLine("De toegevoegde producten zijn :");
                    foreach (Product product in Products)
                    {
                        Console.WriteLine($"ProductID: {product.ProductId}, Naam: {product.ProductName}, Prijs: {product.Price}, Beschrijving: {product.ProductDescription}");
                    }

                    // Toon de totale prijs van de order
                    Console.WriteLine($"OrderID: {order.OrderId}, Totale prijs: {order.CalculateTotalPrice()} euro");

                    // Vraag of de gebruiker nog een order wil plaatsen
                    Console.WriteLine("Wil je nog een order plaatsen? (y/n)");
                    string answerOrder = Console.ReadLine();

                    // Als het antwoord niet "y" is, stop de buitenste loop
                    if (answerOrder != "y")
                    {
                        createAnotherOrder = false;
                        order.GenerateBon();
                    }
                }
            }

            if (menuChoice == 2)
            {

                // Menuchoiseperson
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Add Employee");
                int menuChoicePerson = int.Parse(Console.ReadLine());

                if (menuChoicePerson == 1)
                {
                    List<Customer> customers = new List<Customer>();
                    int currentCustomerId = 1;

                    bool createAnotherCustomer = true;

                    while (createAnotherCustomer)
                    {
                        // Add customer
                        Console.WriteLine("Enter Name:");
                        string customerName = Console.ReadLine();

                        Console.WriteLine("Enter telefoonnummer:");
                        int customerPhoneNumber = int.Parse(Console.ReadLine());

                        // Update customerID met +1
                        int customerID = currentCustomerId++;

                        // Create de customer en voeg toe aan de list
                        Customer newCustomer = new Customer(customerName, customerPhoneNumber, customerID);
                        customers.Add(newCustomer);

                        // Vraag of er nog een customer toegevoegd moet worden.
                        Console.WriteLine("Wil je nog een customer toevoegen (y/n)");
                        string answer = Console.ReadLine();

                        // Als antworod niet y is stop.
                        if (answer != "y")
                        {
                            createAnotherCustomer = false;
                           
                        }
                    }
                    // Print de list van customers
                    Console.WriteLine("List of Customers:");
                    foreach (Customer customer in customers)
                    {
                        Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.Name}, Phone Number: {customer.Phonenumber}");
                    }
                }
                if (menuChoicePerson == 2)
                {
                    List<Employee> employees = new List<Employee>();
                    int currentEmployeeId = 1;

                    bool createAnotherEmployee = true;

                    while (createAnotherEmployee)
                    {
                        // Add een employee
                        Console.WriteLine("Enter Name:");
                        string employeeName = Console.ReadLine();

                        Console.WriteLine("Enter telefoonnummer:");
                        int employeePhoneNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter nieuw salaris");
                        int employeeSalary = int.Parse(Console.ReadLine());

                        // Update employeeID met +1 voor elke iteratie.
                        int employeeId = currentEmployeeId++;

                        // Create de employee en voeg hem toe aan de lijst
                        Employee newEmployee = new Employee(employeeName, employeePhoneNumber, employeeId, employeeSalary);
                        employees.Add(newEmployee);

                        // Vraag of de gebruiker nog een employee wil toevoegen
                        Console.WriteLine("Wil je nog een employee toevoegen? (y/n)");
                        string answer = Console.ReadLine();

                        // Als antworod niet y is stop.
                        if (answer != "y")
                        {
                            
                            createAnotherEmployee = false;                     

                        }
                        foreach (Employee employee in employees)
                        {
                            Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.Name}, Phone Number: {employee.Phonenumber}, Salary, {employee.Salary}");
                        }

                    }

                }
          
            }

            if (menuChoice == 3)
            {
                Console.WriteLine("Work in progress");
            }

            Console.WriteLine("Bedankt en tot ziens!");
            Console.ReadLine();
        }
    }
}
