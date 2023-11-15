using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class EternalGoal : Goal {

    public EternalGoal()
    {

    }
    
    public EternalGoal(string title, string description, int points) : base(title, description, points)
    {
        AddTitle(title);
        AddDescription(description);
        AddPoints(points);
    }

    public override void CreateEternalGoal()
    {
        CreateGoal();
    }

    public override void StringifyGoal()
    {

    }
}