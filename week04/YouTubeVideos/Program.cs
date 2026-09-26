using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.AddComments(new Comment("Commenter 1", "Comment 1"));
        video1.AddComments(new Comment("Commenter 2", "Comment 2"));
        video1.AddComments(new Comment("Commenter 3", "Comment 3"));
        video1.AddComments(new Comment("Commenter 4", "Comment 4"));

        Video video2 = new Video("Title 2", "Author 2", 120);
        video2.AddComments(new Comment("Commenter 1", "Comment 1"));
        video2.AddComments(new Comment("Commenter 2", "Comment 2"));
        video2.AddComments(new Comment("Commenter 3", "Comment 3"));
        video2.AddComments(new Comment("Commenter 4", "Comment 4"));

        Video video3 = new Video("Title 3", "Author 3", 120);
        video3.AddComments(new Comment("Commenter 1", "Comment 1"));
        video3.AddComments(new Comment("Commenter 2", "Comment 2"));
        video3.AddComments(new Comment("Commenter 3", "Comment 3"));
        video3.AddComments(new Comment("Commenter 4", "Comment 4"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var v in videos)
        {
            Console.WriteLine(v.GetDisplayInformation());
        }
    }
}