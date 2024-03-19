using System;
using System.Text.RegularExpressions;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }
    public void Shipping()
    {
        Console.WriteLine("Shipping Label: ");
        
        customer.DisplayCustomer();
        
    }
    public void Packing()
    {
        Console.WriteLine("Packing Label: ");

        foreach (Product product in products)
        {
            product.DisplayProduct();
        }
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public double Cost()
    {
        double totalprice = 0;
        foreach (Product product in products)
        {
            double cost = product.Price();
            totalprice += cost;
        }
        return totalprice;
    }
    public double TotalCost()
    {
        double totalCost = Math.Round(Cost() + customer.ShippingCost(),2);

        return totalCost;
    }
    public void DisplayCost(double totalPrice, double shipping, double totalCost)
    {
        Console.WriteLine($"Total Without Shipping: ${totalPrice}");
        Console.WriteLine($"Shipping Costs: ${shipping}");
        Console.WriteLine($"Total: ${totalCost}");
    }
    


}