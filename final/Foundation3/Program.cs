using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Jeremy's Bible Study", "Come listen to Jeremy give a rousing discussion of Acts.", "11/11/2024", "9:45am", "Ricks 224","Jeremy Hunter", "85" );
        Console.WriteLine("//////////////////////////////////////////");
        Console.WriteLine(lecture.Intro());
        Console.WriteLine(lecture.GetLecture());
        Console.WriteLine("//////////////////////////////////////////");

        Console.WriteLine();

        Reception reception = new Reception("Tanner's Wedding Reception", "Come celebrate the union of Tanner And Gentry", "12th of may 2025", "1:00pm", "Taylor Gym", "TanTheMan@Yahoo.uk" );
        Console.WriteLine("//////////////////////////////////////////");
        Console.WriteLine(reception.Intro());
        Console.WriteLine(reception.GetEmail());
        Console.WriteLine("//////////////////////////////////////////");

        Console.WriteLine();

        Outdoor outdoor = new Outdoor("Hiking R Mountian", "Lets Hike R Mountian together", "8/12/2024", "9:00am","Base of R mountian", "Partly Cloudy");
         Console.WriteLine("//////////////////////////////////////////");
        Console.WriteLine(outdoor.Intro());
        Console.WriteLine(outdoor.GetWeather());
        Console.WriteLine("//////////////////////////////////////////");
        
    }
}