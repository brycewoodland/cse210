using System.Xml.Serialization;

public class ReflectingActivity : Activity {

    private List<string> _prompts = new List<string>() 
    {
        "-- Think of a time when you stood up for someone else. --",
        "-- Think of a time when you did something really difficult. --",
        "-- Think of a time when you helped someone in need. --",
        "-- Think of a time when you did something truly selfless. --"
    };
    private List<string> _questions = new List<string>() 
    {
        "-- Why was this experience meaningful to you? --",
        "-- Have you ever done anything like this before? --",
        "-- How did you get started? --",
        "-- How did you feel when it was complete? --",
        "-- What made this time different than other times when you were not as succesful? --",
        "-- What is your favorite thing about this experience? --",
        "-- What could you learn from this experience that applies to other situations? --",
        "-- What did you learn about yourself through this experience? --",
        "-- How can you keep this experience in mind in the future? --"
    };

    public ReflectingActivity() : base("Reflecting Activity",  "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void ShowRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine($"{randomPrompt}");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        string choice = Console.ReadLine();

        if (choice == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Begin();
        }
    }

    public void ShowRandomQuestions(int remainingTime)
    {
        while (remainingTime > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _questions.Count);
            string randomQuestion = _questions[randomIndex];

            Console.WriteLine($"{randomQuestion}");
            Thread.Sleep(10000);
            remainingTime -= 10;
        }
        Console.Clear();
    }

    public void Begin() 
    {
        Console.Write("You may begin in: ");
        GetTime();
        Console.Clear();
    }

    public void Reflect()
    {
        StartingMessage();
        SetTime();
        GetReady();
        ShowRandomPrompt();
        ShowRandomQuestions(_time);
        ClosingMessage();
    }
}