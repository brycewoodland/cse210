using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class EternalGoal : Goal {

    public EternalGoal(string title, string description)
    {
        AddTitle(title);
        AddDescription(description);
    }

    public override void StringifyGoal()
    {

    }
}