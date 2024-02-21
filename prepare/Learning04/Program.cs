using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Perry Limy", "History");
        Console.WriteLine(assign1.StudentInfo());
        Console.WriteLine();

        MathAssignment assign2 = new MathAssignment("Jessie Markly", "Division", "8.1","2-15");
        Console.WriteLine(assign2.StudentInfo());
        Console.WriteLine(assign2.GetHomework());
        Console.WriteLine();

        WritingAssignment assign3 = new WritingAssignment("Steve Polme", "17th Century", "Early America");
        Console.WriteLine(assign3.StudentInfo());
        Console.WriteLine(assign3.GetWriting());
        Console.WriteLine();

    }
}

