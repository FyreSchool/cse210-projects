using System;
using System.Xml;

public class Swimming : Activity
{
    private double distance;
    

    public Swimming(string date, double length, double distance) : base(date,length)
    {
        this.distance = distance;
    }

    public override double Distance()
    {
        return distance;
    }
    public override double Pace()
    {
        double pace = length / distance;
        return Math.Round(pace,1);
    }
    public override double Speed()
    {
        double speed = ((distance * 50 / 1000 * 0.62)/length) * 60;
        return Math.Round(speed,1);
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{date} Swimming ({length} min)- Distance {distance} laps, Speed {Speed()} mph, Pace: {Pace()} min per lap.");
    }
}