using System;
using System.Runtime.CompilerServices;

public class Product
{
    private string name;
    private string productID;
    private double pricePer;
    private int quantity;

    public Product (string name, string productID, double pricePer, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.pricePer = pricePer;
        this.quantity = quantity;
    }

    public double Price()
    {
        return Math.Round(pricePer * quantity,2);
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{name}: {productID}, quantity: {quantity} Total: ${Price()}");
    }

    
}