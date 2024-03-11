using System;

public class Goal
{
    protected string goalName;
    protected string goalDescription;
    protected int goalPoints;

    public List<string> goals = new List<string>();

    public Goal(string goalName, string goalDescription)
    {
        this.goalName = goalName;
        this.goalDescription = goalDescription;
    }

    public string GetGoalName()
    {
        Console.WriteLine("What is the name of your goal? ");
        goalName = Console.ReadLine();
        return goalName;
    }

    public string GetGoalDescription()
    {
        Console.WriteLine("What is a short description of your goal? ");
        goalDescription = Console.ReadLine();
        return goalDescription;
    }
    public int GoalPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal? ");
        goalPoints = Console.ReadLine();
        return goalPoints;
    }
        public void AddToList()
    {
        //add entries to list
        goals.Add();
    }

    public void CreateGoal()
    {
        GetGoalName();
        GetGoalDescription();
        GoalPoints();
    }
} 

