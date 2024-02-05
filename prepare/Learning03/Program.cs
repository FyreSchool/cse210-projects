using System;

class Program
{
    static void Main(string[] args)
    {
        //fraction with one on top and bottom
        Fractions frac1 = new Fractions();
        
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        //fraction of 3 divied by 4
        Fractions frac2 = new Fractions(3,4);

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        //fraction of 18 divied by 4
        Fractions frac3 = new Fractions(18,4);

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        //fraction of 3 divied by 1
        Fractions frac4 = new Fractions(3);

        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());

    }
}

