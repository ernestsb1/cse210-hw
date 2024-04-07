using System;
public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("229 Cap St", "City 1", "State 1", "USA");
        Customer customer1 = new Customer("Customer 1", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Product 1", 1, 10, 2);
        Product product2 = new Product("Product 2", 2, 15, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Packing Label for Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label for Order 1:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Cost for Order 1: $" + order1.GetTotalCost());
        Console.WriteLine();

        Address address2 = new Address("18 Royal Ave", "City 2", "State 2", "Nigeria");
        Customer customer2 = new Customer("Customer 2", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Product 3", 3, 20, 3);
        Product product4 = new Product("Product 4", 4, 25, 1);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Packing Label for Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label for Order 2:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Cost for Order 2: $" + order2.GetTotalCost());
        
    }
}
