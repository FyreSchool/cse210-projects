using System;

public class Resume
{
    public string _myName; 

    public List<Job> _jobs = new List<Job>();
    

    public void DisplayJob()
    {
        Console.WriteLine($"Name: {_myName}");

        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }
}