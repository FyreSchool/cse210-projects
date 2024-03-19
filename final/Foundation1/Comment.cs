using System;

public class Comment
{
    public string comment; 
    public string userName; 

    public void DisplayComment()
    {
        Console.WriteLine($"{userName} \n \n  '{comment}'");
    }

}