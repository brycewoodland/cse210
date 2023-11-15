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

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string targetReps = Console.ReadLine();
        _targetReps = Convert.ToInt32(targetReps);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPoints = Console.ReadLine();
        _completePoints = Convert.ToInt32(bonusPoints);

        _timesDone = 0;
    }

    public override void StringifyGoal()
    {
        base.StringifyGoal();
    }

    public override bool CompleteGoal()
    {
        if (_timesDone >= _targetReps)
        {
            return true;
        }
        else
        {
            return false;
        }
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
