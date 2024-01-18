using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = UserName();

        int userNumber = FavNumber();

        int squaredNumber = NumberSquared(userNumber);

        DisplayInputs(userName, squaredNumber);

    }
    //Displays a welcome message
    static void DisplayWelcome()
    {             
        Console.WriteLine("Welcome to the program!");
    }

    //Asks a user for their name
    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string usersName = Console.ReadLine();

        return usersName;
    }

    //Asks a user for their favorite number
    static int FavNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    //squares a number
    static int NumberSquared(int number)
    {
        int square = number * number;

        return square;
    }

    //displays a users name and the favorite number squared. 
    static void DisplayInputs(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
    }
}