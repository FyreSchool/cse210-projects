using System; 

public class Activity
{
    protected string activityName;
    protected int duration;
    protected string startingMessage;
    protected string activityDescription;

    public Activity(string activityName, string startingMessage, string activityDescription)
    {
        this.activityName = activityName;
        this.startingMessage = startingMessage;
        this.activityDescription = activityDescription;
    }
    public void Animate()
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }

    }

    public string GetActivityName()
    {
        return activityName;
    }
    public void GetReady()
    {
        Console.WriteLine("Get Ready... ");
        Animate();
    }
    public void GetCountDown()
    {
         for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }


    public int GetDuration()
    {
        Console.Write("How long, in Seconds, would you like for your session to be? ");
        int userDuration = int.Parse(Console.ReadLine());
        duration = userDuration;
        return duration;
    }

    public string GetStartingMessage()
    {
        return startingMessage;
    }
    public string GetActivityDescription()
    {
        return activityDescription;
    }

    public void GetFinished(int duration,string activityName)
    {
        Console.WriteLine("Well Done");
        Animate();
        Console.WriteLine( "You have completed " + duration + " of the " + activityName + " activity.");
    }

    public void ActivityStart()
    {
        Console.Clear();
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine();
        Console.WriteLine(GetActivityDescription());
        Console.WriteLine();
        GetDuration();
        GetReady();
        Console.Clear();
    }
    
    
    

}