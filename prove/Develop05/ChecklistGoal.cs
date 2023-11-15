public class ChecklistGoal : Goal {

    private int _completePoints;
    private int _targetReps;
    private int _timesDone;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string title, string description, int points) : base(title, description, points)
    {
        AddTitle(title);
        AddDescription(description);
        AddPoints(points);
    }

    public override void CreateChecklistGoal()
    {
        CreateGoal();
    }

    public override void StringifyGoal()
    {
        base.StringifyGoal();
    }

    public override void CompleteGoal()
    {
        base.CompleteGoal();
    }

    public override void AddPoints(int points)
    {
        base.AddPoints(points);
    }

    public override void DisplayGoal(int index)
    {
        Console.WriteLine($"{index + 1}. [{(_completed ? "X" : " ")}] {_title} ({_description}) - Completed {_timesDone}/{_targetReps} times");
    }
}
