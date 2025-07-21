using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Beach", "CA", "USA");
        Customer customer1 = new Customer("Kevin Bob", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "101-A", 1200.00m, 1);
        Product product2 = new Product("Mouse", "205-A", 25.50m, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("--- Order Details ---");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}\n");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order1.CalculateTotal():F2}"); 

        Address address2 = new Address("789 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Webcam", "303-B", 49.99m, 1);
        Product product4 = new Product("Microphone", "410-C", 75.00m, 1);
        Product product5 = new Product("Headphones", "522-D", 120.00m, 1);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("\n--- Order Details ---");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}\n");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order2.CalculateTotal():F2}");
    }
}