using System;
using System.Linq;

public class Goal
{
    protected string goalName;
    protected string goalDescription;
    protected int goalPoints;
    public static int totalPoints;

    public static List<string> goals = new List<string>();
    public static List<int> points = new List<int>();
    public static List<string> goaldescript = new List<string>();

    public Goal()
    {
    
    }
    public void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        goalName = Console.ReadLine();

        Console.WriteLine("What is a short description of your goal? ");
        goalDescription = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        int.TryParse(Console.ReadLine(), out goalPoints);


        goals.Add(goalName);
        points.Add(goalPoints);
        goaldescript.Add(goalDescription);

        Console.WriteLine("");
        Console.WriteLine($"You have {totalPoints} points. ");
        Console.WriteLine("");
         
    }

    public void DisplayGoal()
    {
        int count = 0;
        Console.WriteLine("");
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {

            count += 1;
            string checkmark = this is EternalGoal ? "[]" : points[i] == 0 ? "[✓]" : "[]";
            Console.WriteLine($"{count}. {checkmark} {goals[i]} ({goaldescript[i]})");
            
        }
        Console.WriteLine("");
        Console.WriteLine($"You have {totalPoints} points. ");
        Console.WriteLine("");
    }

    public void RecordEvent()
    {
        int count = 0;
        Console.WriteLine("The goals are:");
        foreach (var goal in goals)
        {
            count += 1;
            Console.WriteLine($"    {count}. {goal}");
        }
        int goalchoice;
        Console.Write("What goals did you achoplish today?");
        int.TryParse(Console.ReadLine(), out goalchoice);
        Console.WriteLine("");
        
        int totalPointsAdd = 0;

        for (int i = 0; i < goals.Count; i++)
        {
            if (i == goalchoice - 1)
            {
                totalPointsAdd += points[i];
                
                Console.WriteLine($"Congratulations! You have earned {points[i]} points! ");
                points[i] = 0;
                break;
            }

        }
        totalPoints += totalPointsAdd;
        Console.WriteLine("");
        Console.WriteLine($"You have {totalPoints} points. ");
        
    }



} 

