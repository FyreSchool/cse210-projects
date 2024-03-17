using System;

public class ChecklistGoal : Goal
{
    private int basePoints;
    public int timesComplete;
    private int bonusPoints;
    public int goalValue;
    public int bonusCompletions;

    public ChecklistGoal(string name, string description, int basePoints, int bonusPoints, int bonusCompletions,bool complete,int timesComplete) : base("Checklist", name, description, basePoints, bonusPoints, bonusCompletions, complete)
    {
        this.basePoints = basePoints;
        this.bonusPoints = bonusPoints;
        goalValue = bonusCompletions;
        this.timesComplete = timesComplete;
    }

    public override bool IsCompleted()
    {
        return timesComplete == goalValue;
    }
    public override int Record() 
    {
        
        if (timesComplete < goalValue - 1) 
        {
            timesComplete += 1;
            return AddPoints(basePoints);
        }
        else
        {
            timesComplete += 1;
            Completed(true);
            return AddPoints(basePoints + bonusPoints);
        }
    }
    public int GetTimesComplete()
    {
        return timesComplete;
    }
    public int GetGoalValue()
    {
        return goalValue;
    }
    

}