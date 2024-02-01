using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string prompt;
    public string date;
    public string journalEntry;

    public List<string> entries = new List<string>();


    public string GivePrompt()
    {
        List<string> prompts = new List<string>()
        {
            "What was the funniest think that someone said to you today? ",
            "what is the strangest thing that you saw today? ",
            "If you could have done something different today what would it have been? ",
            "Where did you wish that you had gone today? ",
            "What was your favorite thing that you did today? ",
            "Did you give or receive any help today? ",
            "What was your favorite meal of the day? "

        };

        //generate and display a random prompt
        Random rnd = new Random();
        int randPrompt = rnd.Next(prompts.Count);
        prompt = prompts[randPrompt];

        Console.WriteLine(prompt);

        return prompt;

    }

    public void CreateDate()
    {
        //create date to add to entries
        DateTime timeNow = DateTime.Now;

        date = timeNow.ToShortDateString();

    }
    public string CreateEntry()
    {
        //create an entry
        GivePrompt();
        CreateDate();
        Console.Write("> ");

        string userEntry = Console.ReadLine();

        journalEntry = $"{date}\n{prompt}\n{userEntry}\n";


        return journalEntry;
        
    }
    public void AddToList()
    {
        //add entries to list
        entries.Add(journalEntry);
    }
    public void Display()
    {
        //display entries from list
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
        
    }
  

}