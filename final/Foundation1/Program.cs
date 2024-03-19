using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //Create video 1
        Video video1 = new Video();

        video1.creator = "Bob's Builds";
        video1.title = "Building a outdoor pizza oven";
        video1.length = "34:23";

        //Create video 2
        Video video2 = new Video();

        video2.creator = "Nana Cooks";
        video2.title = "Lets bake a shepards pie!!";
        video2.length = "12:17";

        //Create video 3
        Video video3 = new Video();

        video3.creator = "Rob's movies reviews";
        video3.title = "Interstellar review";
        video3.length = "18:48";

        //Create video 4
        Video video4 = new Video();

        video4.creator = "Guy Average";
        video4.title = "Trying to make a three pointer from the roof";
        video4.length = "55:32";

        //Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        //create comments for video 1
        Comment comment1 = new Comment();
        comment1.userName = "PsychoSam"; 
        comment1.comment = "Way better then microwaves and safer.";

        Comment comment2 = new Comment();
        comment2.userName = "KissKiss293";
        comment2.comment = "What is the biggest Pizza this could cook.";

        Comment comment3 = new Comment();
        comment3.userName = "NanaCooks";
        comment3.comment = "This would be perfect for a shepards pie.";

        //create comments for video 2
        Comment comment4 = new Comment();
        comment4.userName = "LovePie";
        comment4.comment = "I love this recipe.";

        Comment comment5 = new Comment();
        comment5.userName = "ILoveFood";
        comment5.comment = "This is a new family recipe.";

        Comment comment6 = new Comment();
        comment6.userName = "SteveHippe182";
        comment6.comment = "I love this recipe";

        //create comments for video 3
        Comment comment7 = new Comment();
        comment7.userName = "MoviesRlife";
        comment7.comment = "One of Nolan's bests.";

        Comment comment8 = new Comment();
        comment8.userName = "karrenBean";
        comment8.comment = "Needed Christian Bale.";

        Comment comment9 = new Comment();
        comment9.userName = "923489523";
        comment9.comment = "Love the review.";

        Comment comment10 = new Comment();
        comment10.userName = "MeanBen";
        comment10.comment = "Wish I was on a space ship.";

        //create comments for video 4
        Comment comment11 = new Comment();
        comment11.userName = "NateTheGreat";
        comment11.comment = "Only took like a 100 shots to make it.";

        Comment comment12 = new Comment();
        comment12.userName = "DudesThatArePerfect";
        comment12.comment = "Keep Trying";

        Comment comment13 = new Comment();
        comment13.userName = "BushMan";
        comment13.comment = "That was Crazy.";

        
        //Add comments to list
        video1.comments.Add(comment1);
        video1.comments.Add(comment2);
        video1.comments.Add(comment3);
        video2.comments.Add(comment4);
        video2.comments.Add(comment5);
        video2.comments.Add(comment6);
        video3.comments.Add(comment7);
        video3.comments.Add(comment8);
        video3.comments.Add(comment9);
        video3.comments.Add(comment10);
        video4.comments.Add(comment11);
        video4.comments.Add(comment12);
        video4.comments.Add(comment13);
        
        //Display videos       
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
        
    }
}