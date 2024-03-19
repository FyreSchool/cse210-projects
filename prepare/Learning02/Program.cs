using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._title = "Life Guard";
        job1._workplace = "Smalltown Public Pool";
        job1._startingYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        
        job2._title = "Plumber";
        job2._workplace = "Al's Crack Repair"; 
        job2._startingYear = 2021;
        job2._endYear = 2023;

        Resume resume = new Resume();

        resume._myName = "Steve Swimmer";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayJob();




    }
}