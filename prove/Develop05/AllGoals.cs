using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;

public class AllGoals
{
    public int totalPoints;
    
    public List<Goal> goalList;
    public int earnedPoints;

    public AllGoals()
    {
        goalList = new List<Goal>();
        totalPoints = 0;  
        earnedPoints = 0;

    }
    public void MakeGoal()
    {
        Console.WriteLine("The Types Of Goals Are:");
            Console.WriteLine("   1. Simple Goal");
            Console.WriteLine("   2. Eternal Goal");
            Console.WriteLine("   3. Checklist Goal");  
            Console.Write("What type of goal would you like to create: ");
            string goalChoice = Console.ReadLine();

            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.WriteLine("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            switch(goalChoice)
            {
                case "1":
              
                    goalList.Add(new SimpleGoal(name, description, points, false));
                   
                    break;

                case "2":

                    goalList.Add(new EternalGoal(name, description, points, false));
                    break;

                case "3":

                    Console.WriteLine("How many times does this goal have to be accomplished for a bonus?");
                    int bonusCompletions = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    int bonusPoints  = int.Parse(Console.ReadLine());

                    goalList.Add(new ChecklistGoal(name, description, points, bonusPoints, bonusCompletions, false,0));

                    break;

                default:

                    Console.WriteLine("Invalid choice!");
                    break;

            }

    }
    public void AddPoints(int points) 
    {
        totalPoints += points;
    }
    public void Display()
    {
        int i = 0;
        foreach (Goal goal in goalList)
        {
            Console.Write($"{i += 1}. ");
            if (goal.IsCompleted()) 
            {
                Console.Write("[x] ");
            }
            else 
            {
                Console.Write("[] ");
            }
               Console.Write($"{goal.GetName()} ({goal.GetDescription()})");
            if (goal is ChecklistGoal checklistGoal) 
            {
                Console.Write($" --- Currently completed: {checklistGoal.GetTimesComplete()}/{checklistGoal.GetGoalValue()}");
            }
            Console.WriteLine();
            
        }
        Console.WriteLine($"\nTotal points: {totalPoints}");
        
        
    }
    public int GetTotalPoints()
    {
        return totalPoints;
    }  
    public void GoalProgress() 
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goalList.Count; i++) 
        {
            Console.WriteLine($"{i + 1}. {goalList[i].GetName()}");
        }
        Console.Write("\nWhich goal did you accomplish?");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goalList.Count) 
        {
            Goal selectedGoal = goalList[choice];

            if (selectedGoal.IsCompleted() != true)
            {
                earnedPoints = selectedGoal.Record();

                if (selectedGoal.IsCompleted()) 
                {
                    Console.WriteLine($"Congratulations! You completed the goal and earned {earnedPoints} points.");
                    totalPoints += earnedPoints;
                }
                else 
                {
                    Console.WriteLine($"Progress recorded. You have earned {earnedPoints} points.");
                    totalPoints += earnedPoints;
                }   
            }
            else 
            {
                Console.WriteLine("You have already completed this goal.");
            }
        }
        else 
        {
            Console.WriteLine("Invalid choice.");
        }

    }
    public void WriteFile() 
    {
        Console.WriteLine("Please enter a name for your file");
        string fileName = Console.ReadLine() + ".txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal goal in goalList) 
            {
                if (goal is SimpleGoal simpleGoal) 
                {
                    outputFile.WriteLine($"Simple:{simpleGoal.GetName()}:{simpleGoal.GetDescription()}:{simpleGoal.Points()}:{simpleGoal.IsCompleted()}");
                }
                else if (goal is EternalGoal eternalGoal) 
                {
                    outputFile.WriteLine($"Eternal:{eternalGoal.GetName()}:{eternalGoal.GetDescription()}:{eternalGoal.Points()}:{eternalGoal.IsCompleted()}");
                }
                else if (goal is ChecklistGoal checklistGoal) 
                {
                    outputFile.WriteLine($"Checklist:{checklistGoal.GetName()}:{checklistGoal.GetDescription()}:{checklistGoal.Points()}:{checklistGoal.IsCompleted()}:{checklistGoal.GetBonusPoints()}:{checklistGoal.GetBonusComplete()}:{checklistGoal.GetTimesComplete()}");
                }
            }
        }
    }
    public void LoadFile() 
    {
        Console.WriteLine("Please enter the name of the file you would like to load");
        string _fileName = Console.ReadLine() + ".txt";
        goalList.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            if (parts.Length >= 4)
            {
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);

                if (type == "Simple")              
                {
                    goalList.Add(new SimpleGoal(name, description, points, complete));
                }
                else if (type == "Eternal") 
                {
                    goalList.Add(new EternalGoal(name, description, points, complete));
                }
                else if (type == "Checklist") 
                {
                    int bonusPoints = int.Parse(parts[5]);
                    int bonusCompletions = int.Parse(parts[6]);
                    int timesComplete = int.Parse(parts[7]);
                    goalList.Add(new ChecklistGoal(name, description, points, bonusPoints, bonusCompletions,complete, timesComplete));
                }
                else 
                {
                    Console.WriteLine($"Invalid goal type");
                    continue; 
                }
            }
        }
    }
   

}
