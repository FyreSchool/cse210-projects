using System;

class Program
{
    static void Main(string[] args)
    {
        {
        Console.WriteLine("Menu:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflection activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");

        Console.Write("Enter a choice from the menu: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                
                // Add code for Option 1 functionality
                break;
            case "2":
                
                // Add code for Option 2 functionality
                break;
            case "3":
                
                // Add code for Option 3 functionality
                break;
            case "4":
                Console.WriteLine("Exiting...");
                return;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        // Repeat the menu until the user chooses to exit
        Main(args);
    }
    }
}