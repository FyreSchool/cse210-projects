using System;
using System.Threading.Tasks.Dataflow;

public class Breathing : Activity
{
    public Breathing() : base("breathing", "Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing." )
    {
       
    }
    

    public void BreathActivity()
    {   
        ActivityStart();
        
        for (int i = duration / 10; i > -1; i--)
        {
            Console.WriteLine("");
            Console.Write("Breath in... ");
            GetCountDown();

            Console.WriteLine("");
            Console.Write("Breath out... ");
            GetCountDown();

            Console.WriteLine("");
        }
        Console.WriteLine("");
        GetFinished(duration, GetActivityName());
        Console.Clear();


    }
  

    


}