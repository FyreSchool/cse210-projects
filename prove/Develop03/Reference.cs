using System;

//Holds our reference data
public class Reference
{
    private int verse = 25;
    private int chapter = 2;
    private string book = "2 Nephi";
    private string reference;
    
    //creates our reference
    public string DisplayReference()
    {
        reference = $"{book} {chapter}:{verse}";

        return reference;
    }

}