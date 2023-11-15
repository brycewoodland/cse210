public class SimpleGoal : Goal {

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
        Console.WriteLine($"[{(_completed ? "X" : " ")}] {_title} ({_description})");
    }
}