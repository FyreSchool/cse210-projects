using System;

public abstract class Activity
{
    protected string date;
    protected double length;
    
    public Activity(string date, double length)
    {
        this.date = date;
        this.length = length;
    }
    public string GetDate()
    {
        return date;
    }

    public double GetLength()
    {
        return length;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public abstract void GetSummary();
}