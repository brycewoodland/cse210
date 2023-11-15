public class SimpleGoal : Goal {
    
    private bool _completed;

    public SimpleGoal(string title, string description) 
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

    public override void DisplayGoal()
    {
        base.DisplayGoal();
    }
}