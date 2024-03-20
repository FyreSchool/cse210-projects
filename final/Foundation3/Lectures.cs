using System;

public class Lecture : Event
{

    private string speaker;
    private string capacity;

    public Lecture(string title, string description,string date, string time, string address, string speaker, string capacity ) : base(title, description, date, time, address )
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public string GetLecture()
    {
        return $"{speaker} will be presenting for a limited audience of {capacity} people.";
    }
}