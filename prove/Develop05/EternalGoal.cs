using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class EternalGoal : Goal {

    public EternalGoal()
    {
        
    }

    public EternalGoal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public override void CreateChildGoal()
    {
        CreateGoal();
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override void StringifyGoal()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }
}