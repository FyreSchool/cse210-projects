using System;
using System.IO;

int pick = 0;
Entry entry = new Entry();
Journal journal = new Journal();


while (pick != 5)
{
    //Menu options
    Console.WriteLine("Please Select one of the following choices. ");
    Console.WriteLine("1. Write ");
    Console.WriteLine("2. Display ");
    Console.WriteLine("3. Load ");
    Console.WriteLine("4. Save ");
    Console.WriteLine("5. Quit ");

    Console.Write("What would you like to do: ");
    pick = Convert.ToInt32(Console.ReadLine());

    //creates an entry
    if (pick == 1)
    {
        Console.Clear();
        entry.CreateEntry();
        entry.AddToList();

    }
    //displays entries 
    else if (pick == 2)
    {
        entry.Display();
    }
    //load entries from a file
    else if (pick == 3)
    {
        string[] loadedEntries = Journal.LoadFile();

        if (loadedEntries.Length > 0)
        {
            foreach (string loadedEntry in loadedEntries)
            {
                entry.entries.Add(loadedEntry);
            }

        Console.WriteLine("Entries loaded successfully!");
        }
        else
        {
            Console.WriteLine("No entries found in the specified file.");
        }
    }
    //saves entries to a file
    else if (pick == 4)
    {
        Journal.SaveFile(entry.entries.ToArray());
    }
    //ends the program
    else if (pick == 5)
    {
        Console.Clear();
        Console.WriteLine("Thank you for useing our program. ");
    }
    //makes the user enter a valid number
    else
    {
        Console.Clear();
        Console.WriteLine("Please enter a valid choice. ");
    }
}
