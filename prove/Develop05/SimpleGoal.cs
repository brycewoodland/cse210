public class SimpleGoal : Goal {

    public SimpleGoal()
    {
        
    }

    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public override void CreateSimpleGoal()
    {
        CreateGoal();
    }

    public override void StringifyGoal()
    {
        base.StringifyGoal();
    }

    public override bool CompleteGoal()
    {
        return true;
    }

    public override void DisplayGoal(int index)
    {
        base.DisplayGoal(index);
    }
}