using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer ($5 shipping)
        Address address1 = new Address("123 Maple Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Alex Rivera", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Wireless Mouse", "WM-101", 25.00, 2),
            new Product("Mechanical Keyboard", "MK-204", 80.00, 1)
        };
        Order order1 = new Order(customer1, products1);

        // Order 2: International Customer ($35 shipping)
        Address address2 = new Address("42 King Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Priya Sharma", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("USB-C Hub", "UH-302", 30.00, 1),
            new Product("Laptop Stand", "LS-410", 45.00, 2),
            new Product("Desk Mat", "DM-505", 15.00, 1)
        };
        Order order2 = new Order(customer2, products2);

        // Display both orders
        DisplayOrder(order1, 1);
        Console.WriteLine();
        DisplayOrder(order2, 2);
    }

    static void DisplayOrder(Order order, int orderNumber)
    {
        Console.WriteLine($"=== Order {orderNumber} ===");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
    }
}