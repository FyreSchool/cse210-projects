using System;

public class Customer
{
    private string name;
    private Address address;
    
    public Customer (string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{name}\n{address.GetAddress()}");
    }
    public double ShippingCost()
    {
        double shipping;
        if(address.GetCountry() == "USA")
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping;

    }
}