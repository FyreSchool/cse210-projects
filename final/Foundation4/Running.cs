using System;

public class Running : Activity
{
    private double distance;

    public Running(string date, double length, double distance) : base(date,length)
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
        double speed = (distance/length) * 60;
        return Math.Round(speed,1);
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{date} Running ({length} min)- Distance {distance} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile");
    }
}