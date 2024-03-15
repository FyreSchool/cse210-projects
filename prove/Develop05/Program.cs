using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Menu:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");

        Console.Write("Enter a choice from the menu: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
           
            case "1": 
                 
                Console.WriteLine("The Types Of Goals Are:");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");  
                Console.Write("What type of goal would you like to create: ");
                string goalChoice = Console.ReadLine();
                
                switch (goalChoice)
                {
                    case "1":

                        SimpleGoal simple = new SimpleGoal();
                        break;

                    case "2":
                        EternalGoal eternal = new EternalGoal();
                        break;

                    case "3":

                        break;

                    default:

                        Console.WriteLine("Invalid goal type choice!");
                        break;

                }
                break;
            
            case "2":

                Goal display = new Goal();
                display.DisplayGoal();
                
                break;
            
            case "3":
                
                
                break;

            case "4":

                break;

            case "5":

                Goal record = new Goal();
                record.RecordEvent();
                break;
            //exits program
            case "6":
                Console.WriteLine("Exiting...");
                return;
            //gives error if invaild input is given
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
        Main(args);
    }
}