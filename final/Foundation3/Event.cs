using System;
using System.ComponentModel;

public class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;

    public Event(string title, string description,string date, string time, string address )
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetTitle()
    {
        return title;
    }
    public string GetDate()
    {
        return date;
    }
    public string GetDescription()
    {
        return description;
    }
    public string GetTime()
    {
        return time;
    }
    public string GetAddress()
    {
        return address;
    }
    public string Intro()
    {
        return $"          {title}\n           {date} {time}\n              {address}\n{description}";
    }


    
}