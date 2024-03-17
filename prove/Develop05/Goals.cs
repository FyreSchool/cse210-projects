using System;
using System.Threading.Channels;
using System.Collections.Generic;

public abstract class Goal
{
    protected string goalType;
    public string name;
    public string description;
    public int points;
    public int bonusPoints;
    public int bonusComplete;
    protected bool complete; 

    public Goal (string goalType, string name, string description, int points, bool complete)
    {
        this.goalType = goalType;
        this.name = name;
        this.description = description;
        this.points = points;
        this.complete = complete;
        complete = false;
    }
    public Goal (string goalType, string name, string description, int points, int bonusComplete, int bonusPoints, bool complete)
    {
        this.goalType = goalType;
        this.name = name;
        this.description = description;
        this.points = points;
        this.bonusComplete = bonusComplete;
        this.bonusPoints = bonusPoints;

        complete = false;
    }

    public int AddPoints(int points)
    {
        return points;
    }
    public int Points()
    {
        return points;
    }
    public void Completed(bool complete)
    {
        this.complete = complete;
    }
    public string GetName()
    {
        return name;
    }
    public string GetDescription()
    {
        return description;
    }
    public int GetBonusPoints()
    {
        return bonusPoints;
    }
    public int GetBonusComplete()
    {
        return bonusComplete;
    }
    public abstract int Record();
    public abstract bool IsCompleted();
   
}

