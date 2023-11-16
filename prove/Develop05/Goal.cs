public class Goal {

    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public Goal()
    {

    }

    public Goal(string title, string description, int points)
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

    public virtual void CreateSimpleGoal()
    {

    }

    public virtual void CreateEternalGoal()
    {

    }

    public virtual void CreateChecklistGoal()
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

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_points} points.");
    }

    public virtual void DisplayGoal(int index)
    {
       Console.WriteLine($"{index + 1}. [{(_completed ? "X" : " ")}] {_title} ({_description})");
    }

    public virtual bool CompleteGoal()
    {
        return true;
    }

    public virtual void StringifyGoal()
    {
        
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