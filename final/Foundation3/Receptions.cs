using System;

public class Reception : Event
{
    private string email;
    
    public Reception(string title, string description, string date, string time, string address, string email ): base(title, description, date, time, address )
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return $"Please RSVP to {email}";
    }
}