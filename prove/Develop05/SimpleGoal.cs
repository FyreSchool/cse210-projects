using System;

public class SimpleGoal : Goal
{
    private int simplePoints;
    public SimpleGoal(string name, string description, int simplePoints, bool complete) : base("simple", name, description, simplePoints, complete)
    {
       this.simplePoints = simplePoints;
    }
    public override bool IsCompleted()
    {
       return complete; 
    }
    public override int Record()
    {
        Completed(true);
        return AddPoints(points);

    }
   
}