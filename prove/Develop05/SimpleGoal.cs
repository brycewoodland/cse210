public class SimpleGoal : Goal {

    public SimpleGoal()
    {
        
    }

    public SimpleGoal(string title, string description, int points, bool complete) : base(title, description, points, complete)
    {
        AddTitle(title);
        AddDescription(description);
        AddPoints(points);
        _completed = complete;
    }

    public override void CreateChildGoal()
    {
        CreateGoal();
    }

    public override void StringifyGoal()
    {
        base.StringifyGoal();
    }

    public override void DisplayGoal(int index)
    {
        base.DisplayGoal(index);
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }
}