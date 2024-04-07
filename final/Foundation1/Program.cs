using System;
public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 240);
        video1.Comments.Add(new Comment("Commenter 1", "Comment 1 for video 1"));
        video1.Comments.Add(new Comment("Commenter 2", "Comment 2 for video 1"));
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.Comments.Add(new Comment("Commenter 1", "Comment 1 for video 2"));
        video2.Comments.Add(new Comment("Commenter 2", "Comment 2 for video 2"));
        video2.Comments.Add(new Comment("Commenter 3", "Comment 3 for video 2"));
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 60);
        video3.Comments.Add(new Comment("Commenter 1", "Comment 1 for video 3"));
        video3.Comments.Add(new Comment("Commenter 2", "Comment 2 for video 3"));
        video3.Comments.Add(new Comment("Commenter 3", "Comment 3 for video 3"));


        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.CommenterName + ": " + comment.Text);
            }

            Console.WriteLine();
        }
    }
}
