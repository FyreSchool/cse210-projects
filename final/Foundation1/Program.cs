using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();

        video1.creator = "Bob's Builds";
        video1.title = "Building a outdoor pizza oven";
        video1.length = "34:23";

        Video video2 = new Video();

        video2.creator = "Nana Cooks";
        video2.title = "Lets bake a shepards pie!!";
        video2.length = "12:17";

        Video video3 = new Video();

        video3.creator = "Rob's movies reviews";
        video3.title = "Interstellar review";
        video3.length = "18:48";

        Video video4 = new Video();

        video4.creator = "Guy Average";
        video4.title = "Trying to make a three pointer from the roof";
        video4.length = "55:32";

        video1.videos.Add(video1);
        video2.videos.Add(video2);
        video3.videos.Add(video3);
        video4.videos.Add(video4);

        
        Comment comment1 = new Comment();

        comment1.userName = "PsychoSam"; 
        comment1.comment = "Way better then microwaves and safer.";

        Comment comment2 = new Comment();

        comment2.userName = "KissKiss293";
        comment2.comment = "What is the biggest Pizza this could cook.";

        Comment comment3 = new Comment();

        comment3.userName = "NanaCooks";
        comment3.comment = "This would be perfect for a shepards pie.";

        
    }
}