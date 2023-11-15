public class Goal {

    private string _title;
    private string _description;
    private int _points;

    public Goal()
    {
        _title = "";
        _description = "";
        _points = 0;
    }

    public void AddTitle(string title)
    {
        _title = title;
    }

    public void AddDescription(string description)
    {
        _description = description;
    }

    public virtual void AddPoints()
    {

    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal Name: {_title}");
        Console.WriteLine($"Goal Description: {_description}");
    }

    public virtual void CompleteGoal()
    {

    }

    public virtual void StringifyGoal()
    {
        
    }
}