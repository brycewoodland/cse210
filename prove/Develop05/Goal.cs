public class Goal {

    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public Goal()
    {
        _title = "";
        _description = "";
        _points = 0;
        _completed = false;
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
        _points += points;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal Name: {_title}");
        Console.WriteLine($"Goal Description: {_description}");
    }

    public virtual void CompleteGoal()
    {
        _completed = true;
    }

    public virtual void StringifyGoal()
    {
        
    }
}