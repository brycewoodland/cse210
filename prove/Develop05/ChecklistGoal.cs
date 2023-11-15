public class ChecklistGoal : Goal {

    private int _completePoints;
    private int _targetReps;
    private int _timesDone;

    public ChecklistGoal(string title, string description)
    {
        AddTitle(title);
        AddDescription(description);
    }

    public override void StringifyGoal()
    {
        base.StringifyGoal();
    }

    public override void CompleteGoal()
    {
        base.CompleteGoal();
    }

    public override void AddPoints()
    {
        base.AddPoints();
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
    }
}
