using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("My Video", "John Doe", 120);
        Video video1 = new Video("My Second Video", "Jane Smith", 300);
        Video video2 = new Video("My Third Video", "Mike Johnson", 180);
        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Bob", "Thanks for sharing.");
        Comment comment3 = new Comment("Charlie", "Very informative.");
        video.AddComment(comment1);
        video.AddComment(comment2);
        video.AddComment(comment3);
        video.Display();
        Console.WriteLine();
        video1.AddComment(new Comment("David", "Amazing tutorial!"));
        video1.AddComment(new Comment("Emma", "I learned a lot."));
        video1.AddComment(new Comment("Frank", "Keep it up!"));
        video1.Display();
        Console.WriteLine();
        video2.AddComment(new Comment("Grace", "Excellent content."));
        video2.AddComment(new Comment("Henry", "Very helpful."));
        video2.AddComment(new Comment("Ivy", "Thanks for the insights."));
        video2.Display();
    }
}