using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        

        //Create list for numbers
        List<int> numbers = new List<int>();

        int addNumber = -1;
        int sum = 0;
        int maxNumber = 0;

        //Asking user to enter numbers into the list
        Console.WriteLine("Please enter a list of number, type 0 when finished. ");

        //Runs a loop that lets user add number to the list until they enter 0
        while (addNumber != 0)
        {
            Console.Write("Enter a number: ");
            String number = Console.ReadLine();

            addNumber = int.Parse(number);

            //makes it so 0 is not added to the list
            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        }
        
        //Sums the numbers in list together and finds the biggest number
        foreach (int number in numbers)
        {
            sum += number;
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        //finds the average of the numbers.
        int count = numbers.Count;
        double average = (double)sum / count;

        Console.WriteLine("Sum of numbers: " + sum);
        Console.WriteLine("Average of numbers: " + average);
        Console.WriteLine("The largest number is: " + maxNumber);

    }
}