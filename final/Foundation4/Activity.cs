using System;

public abstract class Activity
{
    protected string date;
    protected double length;
    protected double distance;
    
    public Activity(string date, double length, double distance)
    {
        this.date = date;
        this.length = length;
        this.distance = distance;
    }
    public string GetDate()
    {
        return date;
    }

    public double GetLength()
    {
        return length;
    }

    
    public abstract double Speed();
    public abstract double Pace();
    public abstract void GetSummary();
}