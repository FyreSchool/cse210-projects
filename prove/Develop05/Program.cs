using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        bool keepRunning = true;

        while (keepRunning)
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
                    
                    allGoals.MakeGoal();
                    break;
                
                case "2":

                    allGoals.Display();
                    
                    break;
                
                case "3":
                    
                    allGoals.WriteFile();
                    
                    break;

                case "4":

                    allGoals.LoadFile();
                    break;

                case "5":

                    allGoals.GoalProgress();
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    return;
                //gives error if invaild input is given
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}