using System;

public class Reflection : Activity
{
    public Reflection() : base("reflection", "Welcome to the reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {

    }
    public void ReflectionActivity()
    {
        

        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else. ");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        Random randomprompt = new Random();
        int randomIndex = randomprompt.Next(0, prompts.Count);

        string randomPrompt = prompts[randomIndex];
    
        ActivityStart();
        Console.WriteLine("Consider the following prompt\n");
        Console.WriteLine("---" + randomPrompt + "---\n");
        Console.WriteLine("When you have something in mind, press enter to continue. \n");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to the experince");
        Console.Write("You may begin in: ");
        GetCountDown();
        Console.Clear();
        Question();
        Console.WriteLine();
        GetFinished(duration, GetActivityName());




    }

    public void Question()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;

        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        while (currentTime < futureTime)
        {   
            Random random = new Random();
            int randomIndex = random.Next(0, questions.Count);

            string randomQuestion = questions[randomIndex];
            Console.Write("> " + randomQuestion);
            Animate();
            Console.WriteLine();
            currentTime = DateTime.Now;
        }

    }
}