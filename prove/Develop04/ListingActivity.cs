using System.ComponentModel;

public class ListingActivity : Activity {

    private List<string> _prompts = new List<string>() 
    {
        "-- Who are people that you appreciate? --",
        "-- What are personal strengths of yours? --",
        "-- Who are people that you have helped this week? --",
        "-- When have you felt the Holy Ghost this month? --",
        "-- Who are some of your personal heroes? --"
    };

    public ListingActivity() : base("Listing Activity",  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void UserResponse(int remainingTime)
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(remainingTime);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items.");
    }

    public void ShowRandomPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine($"{randomPrompt}");
        Console.WriteLine();
    }

    public void Begin() 
    {
        Console.Write("You may begin in: ");
        GetTime();
        Console.Clear();
    }

    public void List()
    {
        StartingMessage();
        SetTime();
        GetReady();
        ShowRandomPrompt();
        Begin();
        UserResponse(_time);
        ClosingMessage();
    }
} 