using System.Security.Cryptography.X509Certificates;

public class GoalTracker {

    private List<Goal> _goals = new List<Goal>();
    private int _points;

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal.Title} | {goal.Description} | {goal.Points} | {goal.Completed}");
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string title = parts[0];
            string description = parts[1];
            string points = parts[2];
            string complete = parts[3];

            Goal goal = new Goal();
            goal.AddTitle(title);
            goal.AddDescription(description);
            goal.AddPoints(Convert.ToInt16(points));

            _goals.Add(goal);
        }
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