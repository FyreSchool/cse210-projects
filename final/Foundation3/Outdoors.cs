using System;

public class Outdoor : Event
{
    private string weather;

    public Outdoor (string title, string description,string date, string time, string address, string weather): base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    public string GetWeather()
    {
        return $"Projected weather for the day is {weather}";
    }
}