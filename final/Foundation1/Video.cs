using System;
using System.Threading.Tasks.Dataflow;

public class Video
{
    public string creator;
    public string title;
    public string length;

    public List<Comment> comments = new List<Comment>();
    public List<Video> videos = new List<Video>();


    public void DisplayVideo()
    {
        
        foreach (Video video in videos)
        {

            Console.WriteLine($"{title}, {length}, created by {creator}");

            foreach(Comment comment in comments)
            {
                comment.DisplayComment();
            }
        }
    }
    


}