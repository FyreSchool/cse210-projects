using System;

class Program
{
    static void Main(string[] args)
    {   
        //Askinf user for thier first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //asking user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine();

        //printing out their first and last name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }

}