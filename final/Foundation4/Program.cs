using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running("05 Mar 2024", 45, 5);
        Biking bike1 = new Biking("07 Mar 2024", 60, 15);
        Swimming swim1 = new Swimming("09 Mar 2024", 30,25);

        activities.Add(run1);
        activities.Add(bike1);
        activities.Add(swim1);

        foreach (Activity i in activities)
        {
            i.GetSummary(); 
            Console.WriteLine();   

        }

    }
}