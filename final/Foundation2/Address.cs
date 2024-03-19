using System;

public class Address
{
    private string stAddress;
    private string city;
    private string state;
    private string country;
    public Address (string stAddress, string city, string state, string country)
    {
        this.stAddress = stAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }
    public string GetAddress()
    {
        return ($"{stAddress}\n{city}, {state}\n{country}");
    }
    public string GetCountry()
    {
        return country;
    }
    
}