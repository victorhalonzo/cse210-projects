using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("Valle Alto", "Portoviejo", "Manabí", "Ecuador");
        Customer customer1 = new Customer("Victor", address1);
        Product product1 = new Product("banana", 019, 0.10, 10);
        Product product2 = new Product("water", 001, 0.48, 5);
        Product product3 = new Product("bread", 002, 2.00, 3);
        List<Product> products = [product1, product2, product3];
        Order order1 = new Order(products, customer1);

        Console.WriteLine("----------------------");
        Console.WriteLine("Order #1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine("Name Id");
        Console.WriteLine("----------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("-----------------");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("-----------------");
        Console.WriteLine($"Total price: ${order1.GetTotalPrice():F2}");

        Address address2 = new Address("Eloy Alfaro", "Chone", "Manabí", "Ecuador");
        Customer customer2 = new Customer("Sandra", address2);
        Product product4 = new Product("orange", 019, 0.25, 10);
        Product product5 = new Product("yogurt", 001, 0.98, 3);
        Product product6 = new Product("eggs", 002, 0.20, 5);
        products = [product4, product5, product6];
        Order order2 = new Order(products, customer2);

        Console.WriteLine("----------------------");
        Console.WriteLine("Order #2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine("Name Id");
        Console.WriteLine("----------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("-----------------");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("-----------------");
        Console.WriteLine($"Total price: ${order2.GetTotalPrice():F2}");
    }
}