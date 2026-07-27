using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");  

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", "P001", 800, 1);
        Product product2 = new Product("Mouse", "P002", 25, 2);
        Product product3 = new Product("Keyboard", "P003", 50, 1);
        
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}