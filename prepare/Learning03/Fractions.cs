using System;

public class Fractions
{
    private int topFraction;
    private int bottomFraction;

    public Fractions()
    {
        topFraction = 1;
        bottomFraction = 1;
    }

    public Fractions(int number)
    {
        topFraction = number;
        bottomFraction = 1;
    }

    public Fractions(int top, int bottom) 
    {
        topFraction = top;
        bottomFraction = bottom;
    }

    public string GetFractionString()
    {
        string frac = $"{topFraction}/{bottomFraction}";
        return frac;
    }

    public double GetDecimalValue()
    {
        double decimalFraction = (double)topFraction / (double)bottomFraction;
        return decimalFraction;
    }

}