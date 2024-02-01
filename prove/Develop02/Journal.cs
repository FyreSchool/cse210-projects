using System;

public class Journal
{   
    public static void SaveFile(string[] lines)
    {
        //saves the entries as a file
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }
    public static string[] LoadFile()
    {
        //loads a entries from a file
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();

        if (System.IO.File.Exists(filename))
        {
            return System.IO.File.ReadAllLines(filename);
        }
        else
        {
            Console.WriteLine($"File '{filename}' not found.");
            return new string[0]; 
        }      
    }
}