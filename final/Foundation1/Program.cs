using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Charlie bit my finger!", "woodacoulda", 300);
        v1.AddComment("User1", "LOL");
        v1.AddComment("User2", "This is hilarious!");

        Video v2 = new Video("What are frogs?", "Alex G", 400);
        v2.AddComment("User3", "This has always been my favorite video!");
        v2.AddComment("User4", "One of the funniest videos!");

        Video v3 = new Video("Baked In A buttery Flaky Crust", "Sutherland Weston Marketing", 500);
        v3.AddComment("User5", "The fact that she can't say it either after being so mad!");
        v3.AddComment("User6", "LOL! The bloopers have more views then the actual video.");

        Video v4 = new Video("If Breaking Bad Was Made by Disney", "Buried Entertainment", 600);
        v4.AddComment("User6", "I love how the teenager is the main character like Disney usually does.");
        v4.AddComment("User7", "This isn't Breaking Bad this is Fixing Good.");

        List<Video> _videos = new List<Video> {v1, v2, v3, v4};

        foreach (Video video in _videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}