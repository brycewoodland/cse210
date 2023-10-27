using System.ComponentModel;

public class ListingActivity : Activity {

    private List<string> _prompts = new List<string>() 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void UserResponse()
    {

    }

    public void ShowRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine($"{randomPrompt}");
    }

    public void List()
    {
        StartingMessage();
        SetTime();
        TimerAnimation();
        ShowRandomPrompt();
        ClosingMessage();
    }
}