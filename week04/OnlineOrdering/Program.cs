using System;

class Program
{
    static void Main(string[] args)
    {

        Order order1 = new Order(new Customer("Name 1", new Address("street1", "city1", "state1", "country1")));
        order1.AddProduct(new Product("name 1", 1, 1, 20));
        order1.AddProduct(new Product("name 2", 2, 2, 30));
        order1.AddProduct(new Product("name 3", 5, 3, 40));

        Order order2 = new Order(new Customer("Name 2", new Address("street2", "city2", "state2", "USA")));
        order2.AddProduct(new Product("name 1", 4, 2, 30));
        order2.AddProduct(new Product("name 2", 5, 3, 40));
        order2.AddProduct(new Product("name 3", 6, 4, 50));

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Sipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCostOfOrder()}");

        Console.WriteLine("---------------------------------------");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Sipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalCostOfOrder()}");

    }
}