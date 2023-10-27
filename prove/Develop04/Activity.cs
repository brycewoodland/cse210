public class Activity {
    private string _name;
    private string _description;
    private int _time;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void TimerAnimation()
    {
        Console.WriteLine("+");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("-");
    }

    public void ClosingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name}");
    }

    public void StartingMessage()
    {   
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
    }

    public void SetTime(int time)
    {
        _time = time;
    }
}