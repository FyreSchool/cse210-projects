using System;

public class Biking : Activity
{ 

    public Biking(string date, double length, double distance) : base(date,length,distance)
    {
        
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
        System.Console.WriteLine($"{date} Biking ({length} min)- Distance {distance} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile");
    }
}