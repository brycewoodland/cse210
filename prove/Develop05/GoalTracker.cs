using System;
using System.Collections.Generic;
using System.IO;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;

    public List<Goal> Goals
    {
        get { return _goals; }
    }

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

    public void RecordEventForGoal()
    {
        Console.WriteLine("\nWhich goal would you like to record an event for?");
        DisplayAllGoals();

        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 1)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            selectedGoal.RecordEvent();
            UpdatePoints();
        }
        else
        {
            Console.WriteLine("Invalid goal selection. Please try again.");
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

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_points} points.");
    }

    public void UpdatePoints()
    {
        _points = 0;

        foreach (Goal goal in _goals)
        {
            if (goal.Completed)
            {
                _points += goal.Points;
            }
        }
    }
}