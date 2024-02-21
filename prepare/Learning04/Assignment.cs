using System;
using Microsoft.VisualBasic;

public class Assignment
{
    private string studentName;
    private string topic;
    public Assignment(string studentName, string topic)
    {
        this.studentName = studentName;
        this.topic = topic;
    }

    public string GetTopic()
    {
        return topic;
    }

    public string GetStudentName()
    {
        return studentName;
    }

    public string StudentInfo()
    {
        string info = studentName + " - " + topic;
        return info;
    }
    
}