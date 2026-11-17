using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Collect the videos so they can be displayed in one loop.
        List<Video> videos = new List<Video>();

        // create the first video
        // Video lengths are measured in seconds.
        Video video1 = new Video(
            "The Power of Spiritual Momentum",
            "President Russell M. Nelson",
            1020
        );
        video1.AddComment(new Comment("David", "This message reminds me to keep strengthening my faith."));
        video1.AddComment(new Comment("Mary", "I love how this talk teaches us to stay spiritually strong."));
        video1.AddComment(new Comment("Peter", "A wonderful message. Thank you for sharing!"));
        videos.Add(video1);

        Video video2 = new Video(
            "The Character of Christ",
            "Elder David A. Bednar",
            1200
        );
        video2.AddComment(new Comment("James", "This message teaches me to become more like Jesus Christ."));
        video2.AddComment(new Comment("Sarah", "I really enjoyed learning about the character of Christ."));
        video2.AddComment(new Comment("Daniel", "A powerful message that I will always remember."));
        videos.Add(video2);

        Video video3 = new Video(
            "The Love of God",
            "President Dieter F. Uchtdorf",
            900
        );
        video3.AddComment(new Comment("Michael", "This message reminds me that Heavenly Father loves everyone."));
        video3.AddComment(new Comment("Grace", "I love the reminder that God's love is always there."));
        video3.AddComment(new Comment("Samuel", "This talk has strengthened my faith."));
        videos.Add(video3);

        Video video4 = new Video(
            "The Continuous Atonement",
            "Brad Wilcox",
            1500
        );
        video4.AddComment(new Comment("Alice", "I learned that the Atonement of Jesus Christ is always available to us."));
        video4.AddComment(new Comment("Robert", "This message gives me hope and encourages me to keep trying."));
        video4.AddComment(new Comment("Linda", "A beautiful explanation of the grace of Jesus Christ."));
        videos.Add(video4);

        // Display each video and its comments.
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
