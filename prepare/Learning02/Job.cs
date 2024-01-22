using System;

public class Job
{
    public string _workplace;
    public string _title;
    public int _startingYear;
    public int _endYear;

    public void DisplayJob()

    {
        Console.WriteLine($"{_workplace}: ({_title}) {_startingYear}-{_endYear}");
    }

}