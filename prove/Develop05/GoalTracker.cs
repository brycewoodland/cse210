using System.Security.Cryptography.X509Certificates;

public class GoalTracker {

    private List<Goal> _goals = new List<Goal>();
    private int _points;

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }

    public void DisplayAllGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
        }
        else
        {
            Console.WriteLine("\nList of Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                _goals[i].DisplayGoal(i);
            }
            Console.WriteLine();
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}