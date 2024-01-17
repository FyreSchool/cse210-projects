using System;

class Program
{
    static void Main(string[] args)
    {   
        //Generate a random number to use as magic number
        

        //Ask user to start guessing the magic number
        Console.WriteLine("Try to guess the magic number.  ");
       
        int guess = -1;
        int counter = 1;
        string play = "yes";

        while (play == "yes")
        {
            //Generate a random number to use as magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
        //Reset guess
            guess = -1;
            counter= 1;

            //Enter the game loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower ");
                    counter ++;
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher ");
                    counter++;
                }
                else if (guess == magicNumber)
                {
                    //Tell user they guessed the magic number and give number of guesses.
                    Console.WriteLine("You guessed it!!! ");
                    Console.WriteLine($"It took you {counter} guesses. ");

                    //Ask user if they want to play again
                    Console.WriteLine("Would you like to play again? ");
                    Console.Write("Type yes or no: ");
                    play = Console.ReadLine();

                    if (play == "yes")
                    {
                        play = "yes";
                    }
                    else 
                    {
                        play = "no";
                    }
                }
            }
        }
    }
}