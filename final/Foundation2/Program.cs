using System;

class Program
{
    static void Main(string[] args)
    {   //order 1
        Product order1product1 = new Product("Eggs", "9970", 2.75, 5);
        Product order1product2 = new Product("PorkChop", "29102", 5.15, 3);
        Address address1 = new Address("1492 Ocean St", "Columbus","Ohio", "USA");
        Customer customer1 = new Customer("Christopher Perry", address1);

        double order1Shipping = customer1.ShippingCost();

        Order order1 = new Order(customer1);
        order1.AddProduct(order1product1);
        order1.AddProduct(order1product2);
        double order1Cost = order1.Cost();
        double order1Total = order1.TotalCost();

        //order 2
        Product order2product1 = new Product("Bacon", "1375", 4, 2);
        Product order2product2 = new Product("Grapes", "3333", 6.35, 3);
        Product order2product3 = new Product("Cheese", "24601", 2.5, 7);
        Product order2product4 = new Product("Sprite", "943", 1.75, 12);
        Address address2 = new Address("97th st", "Edmonton","Alberta", "Canada");
        Customer customer2 = new Customer("Conner McDavid", address2);

        double order2Shipping = customer2.ShippingCost();

        Order order2 = new Order(customer2);
        order2.AddProduct(order2product1);
        order2.AddProduct(order2product2);
        order2.AddProduct(order2product3);
        order2.AddProduct(order2product4);
        double order2Cost = order2.Cost();
        double order2Total = order2.TotalCost();

        //display order 1
        Console.WriteLine("////////////////////////////////////");
        order1.Shipping(); 
        Console.WriteLine();
        order1.Packing();
        Console.WriteLine();
        order1.DisplayCost(order1Cost ,order1Shipping, order1Total);
        Console.WriteLine("////////////////////////////////////");
        Console.WriteLine();
        //display order 2
        Console.WriteLine("////////////////////////////////////");
        order2.Shipping(); 
        Console.WriteLine();
        order2.Packing();
        Console.WriteLine();
        order2.DisplayCost(order2Cost ,order2Shipping, order2Total);
        Console.WriteLine("////////////////////////////////////");

    }
}