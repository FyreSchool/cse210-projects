using System;

public class Activity
{
    private string activityName;
    private string time;
    private string startingMessage;

    public Activity(string activityName, string time, string startingMessage)
    {
        this.activityName = activityName;
        this.time = time;
        this.startingMessage = startingMessage;
    }
    public void Animate()
    {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write('\\');
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/"); 
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write('\\');

    }

    public string GetActivityName()
    {
        return activityName;
    }

    public int GetDuration()
    {
        Console.WriteLine("How long, in Seconds, would you like for your session to be? ");
        string time = Console.ReadLine();
        int duration = int.Parse(time);
        return duration;
    }

    public string GetStartingMessage()
    {
        return startingMessage;
    }

    public void GetFinished(int duration,string activityName)
    {
        Console.WriteLine("Well Done");
        Animate();
        Console.WriteLine( "You have completed " + duration + " of the " + activityName + "activity.");
    }
    
    
    

}