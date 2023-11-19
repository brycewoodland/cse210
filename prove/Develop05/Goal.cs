public class Goal {

    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public Goal()
    {

    }

    public Goal(string title, string description, int points, bool complete)
    {
        _title = title;
        _description = description;
        _points = points;
        _completed = false;
    }

    protected void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }

    public virtual void CreateChildGoal()
    {

    }

    public void AddTitle(string title)
    {
        _title = title;
    }

    public void AddDescription(string description)
    {
        _description = description;
    }

    public virtual void AddPoints(int points)
    {
        _points = points;
    }

    public virtual void DisplayGoal(int index)
    {
       Console.WriteLine($"{index + 1}. [{(_completed ? "X" : " ")}] {_title} ({_description})");
    }

    public virtual bool IsComplete()
    {
        return false;
    }
    
    public virtual void RecordEvent()
    {
        Console.WriteLine($"Event recorded for goal: {_title}");

        if (!Completed)
        {
            Completed = true;
            Console.WriteLine($"Goal '{_title}' completed!");
        }
        else
        {
            Console.WriteLine($"Goal '{_title}' already completed.");
        }
    }

    public virtual void StringifyGoal()
    {
        Console.WriteLine($"Goal: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Status: {(IsComplete() ? "Completed" : "Not Completed")}");
    }
    
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }

    public bool Completed
    {
        get { return _completed; }
        set { _completed = value; }
    }
}