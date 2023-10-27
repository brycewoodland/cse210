public class Activity {
    private string _name;
    private string _description;
    private int _time = 30;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartingMessage()
    {   
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
    }

    public void SetTime()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
    }

    public void TimerAnimation()
    {
        Console.Write("|");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("/");

        Thread.Sleep(500);
        
        Console.Write("\b \b");
        Console.Write("-");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("\\");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.WriteLine();
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        TimerAnimation();
    }

    public void ClosingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name}");
        Console.WriteLine();
    }
}