using System;

class Program
{
    static void Main(string[] args)
    {
        //menu options
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflection activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");

        Console.Write("Enter a choice from the menu: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            //start breathing program
            case "1": 
                 
                Breathing breathActivity = new Breathing();
                breathActivity.BreathActivity();
                
                break;
            //start reflection program
            case "2":
                
                Reflection reflectionActvity = new Reflection();
                reflectionActvity.ReflectionActivity();
                
                break;
            //start listing activity
            case "3":
                
                Listing listingActivity = new Listing();
                listingActivity.ListingActivity();

                break;
            //exits program
            case "4":
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