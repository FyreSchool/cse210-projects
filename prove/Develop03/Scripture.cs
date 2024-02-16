using System;
using System.ComponentModel.DataAnnotations;

  //Holds our scripture in a list
class Scripture
{
    public List<string> words = new List<string>()
    {
        "Adam","fell","that","men","might","be;","and","men","are,","that","they","might","have", "joy."
    };

    //Displays our scripture and reference together.
    public void DisplayScripture()
    {
        Reference referenceInstance = new Reference();
        string reference = referenceInstance.DisplayReference();

        //prints out each word and a space. 
        Console.Write(reference + " ");
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
    }
}
  