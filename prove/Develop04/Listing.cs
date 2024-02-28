 using System;

 public class Listing : Activity
 {
    public Listing() : base("Listing","Welcome to the Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    public void ListingActivity()
    {
        
        //sets a list of prompts
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        //get a random prompt
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);
        string randomPrompt = prompts[randomIndex];

        //listing activity start
        ActivityStart();
        Console.WriteLine("List as many responses as you can to the following prompt: \n");
        Console.WriteLine("---" + randomPrompt + "---");
        Console.Write("You may begin in: ");
        GetCountDown();
        Console.WriteLine();

        TimeLimit();

        GetFinished(duration, GetActivityName());

    }
    public void TimeLimit()
    {
        //sets time for timer
        int count = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;

        //lets user type input while timer still has time
        while (currentTime < futureTime)
        {
            //gives user a spot to write to
            Console.Write("> ");
            Console.ReadLine();
            count += 1;

            //update time in the loop
            currentTime = DateTime.Now;
        }
        Console.WriteLine("You listed " + count + " responses.");
    }
 }