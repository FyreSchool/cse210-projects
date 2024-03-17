using System;

public class EternalGoal : Goal
{
    private int eternalPoints;
    public EternalGoal(string name, string description, int eternalPoints, bool complete) : base("Eternal", name, description, eternalPoints, complete)
    {
        this.eternalPoints = eternalPoints;
    }
    public override int Record()
    {
        return AddPoints(eternalPoints);
    }
    public override bool IsCompleted()
    {
        return complete;
    }
    

}