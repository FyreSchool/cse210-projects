using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Word words = new Word();
        Scripture scripture = new Scripture();
        
        //loop to remove words from scripture
        while (true)
        {
            //end program if all words are removed. 
            if  (words.removedWords.Count == scripture.words.Count)
            {
                Console.Clear();
                scripture.DisplayScripture();
                break;
            }
  
            //Displays scripture with missing words.
            Console.Clear();
            scripture.DisplayScripture();

            words.RemoveWord(scripture.words, 2);

            string input = Console.ReadLine();

            //exit program if user types exit.
            if (input == "exit")
            {
                Console.Clear();
                scripture.DisplayScripture();
                break;
            }           

        }
    }
      
}