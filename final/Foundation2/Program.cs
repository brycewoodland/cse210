using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Murray", "UT", "United States");
        Address address2 = new Address("543 Esperanza Calle", "Quito", "Pichincha", "Ecuador");

        Customer customer1 = new Customer("Bryce Woodland", address1);
        Customer customer2 = new Customer("Pablo Picasso", address2);

        Product p1 = new Product("Widget Spinner", "W001", 10.99m, 2);
        Product p2 = new Product("Iphone", "P002", 547.27m, 1);
        Product p3 = new Product("Mochila", "M003", 14.99m, 1);
        Product p4 = new Product("Zapatos", "Z004", 54.99m, 2);

        Order o1 = new Order(customer1);
        Order o2 = new Order(customer2);

        o1.AddProduct(p1);
        o1.AddProduct(p2);
        Console.WriteLine();
        o2.AddProduct(p3);
        o2.AddProduct(p4);

        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine($"Total Price: {o1.TotalPrice()}");
        Console.WriteLine();
        Console.WriteLine(o2.PackingLabel());
        Console.WriteLine(o2.ShippingLabel());
        Console.WriteLine($"Total Price: {o2.TotalPrice()}");

    }
}