using System;
using System.Collections.Generic;

public class Word
{
    //list of removed words to compare to list of scripture words.
    public List<int> removedWords = new List<int>();
    
    //Removes word and replaces it with underscores. 
    public void RemoveWord (List<string> words, int count)
    {
        Random random = new Random();
        int randomIndex;

        for (int i = 0; i < count; i++)
        {
            //Keeps track of words already removed. 
            do
            {
                randomIndex = random.Next(0, words.Count);

            }while (removedWords.Contains(randomIndex));
            
  
            words[randomIndex] = new string('_', words[randomIndex].Length);
            removedWords.Add(randomIndex);
        }
    }

}