using System;

public class MathAssignment : Assignment
{
    private string textBookSection;
    private string problems;
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        this.textBookSection = textBookSection;
        this. problems = problems;
    }

    public string GetHomework()
        {
            return $"section { textBookSection} Problems {problems}";
        }
    
    
}