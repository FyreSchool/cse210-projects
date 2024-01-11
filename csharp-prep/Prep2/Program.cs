using System;

class Program
{
    static void Main(string[] args)
    {
        //ask user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        //convert user input to int
        int num_grade = int.Parse(grade);

        string letter = "n/a";

        //Calculate the users grade 
        if (num_grade >= 90)
        {
            letter = "A";
        }
        else if (num_grade >= 80)
        {
            letter = "B";
        }
        else if (num_grade >= 70)
        {
            letter = "C";
        }
        else if (num_grade >= 60)
        {
            letter = "D";
        }
        else if (num_grade < 60)
        {
            letter = "F";
        }

        //find remainder to use in Plus or Minus grade
        int num_grade_symbol = num_grade % 10;

        //print users grade 
        Console.Write($"Your grade is {letter}");

        //Add Plus or Minus to grade
        if (num_grade_symbol >= 7 & num_grade < 90 & letter != "F")
        {
            Console.Write('+');
        }
        else if (num_grade_symbol <= 3 & num_grade >= 60)
        {
            Console.Write('-');
        }
        
        //print message to user saying if they passed or failed the class.
        Console.WriteLine();

        if (num_grade >= 70 )
        {
            Console.Write("You passed!!!");
        }
        else
        {
            Console.Write("You did not pass the class. Better luck next time. ");
        }
    }
}