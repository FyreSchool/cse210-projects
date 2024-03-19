using System;
using System.Threading.Tasks.Dataflow;

public class Video
{
    public string creator; 
    public string title;
    public string length;

    public List<Comment> comments = new List<Comment>();
    


    public void DisplayVideo()
    { 
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine($"{title}, {length}, created by {creator}");
        Console.WriteLine("-----------------------------------------------------------------\n");
        int commentCount = comments.Count();
        Console.WriteLine($"Comments ({commentCount}):");
        

        foreach(Comment comment in comments)
        { 
            
            comment.DisplayComment();
            
        }
        
    }
    


}