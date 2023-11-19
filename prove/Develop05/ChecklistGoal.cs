public class ChecklistGoal : Goal {

    protected int _completePoints;
    protected internal int _targetReps;
    protected internal int _timesDone;

    public ChecklistGoal()
    {
       
    }

    public ChecklistGoal(string title, string description, int points, bool complete, int targetReps, int timesDone) : base(title, description, points, complete)
    {
       _title = title;
       _description = description;
       _points = points;
       _targetReps = targetReps;
       _timesDone = timesDone;
    }

    public override void CreateChildGoal()
    {
        CreateGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string targetReps = Console.ReadLine();
        _targetReps = Convert.ToInt32(targetReps);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPoints = Console.ReadLine();
        _completePoints = Convert.ToInt32(bonusPoints);

        _timesDone = 0;
    }

    public override void StringifyGoal()
    {
        base.StringifyGoal();
    }

    public bool CompleteGoal()
    {
        if (_timesDone >= _targetReps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void AddPoints(int points)
    {
        base.AddPoints(points);
    }

    public override void DisplayGoal(int index)
    {
        Console.Write($"{index + 1}. [");

        if (_completed)
        {
            Console.Write("X");
        }
        else
        {
            Console.Write(" ");
        }

        Console.WriteLine($"] {_title} ({_description}) - Completed {_timesDone}/{_targetReps} times ");
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for goal: {_title}");

        if (!_completed)
        {
            _timesDone++;

            if (_timesDone >= _targetReps)
            {
                _completed = true;
                Console.WriteLine($"Goal '{_title}' completed!");
            }
            else
            {
                Console.WriteLine($"Goal '{_title}' completed {_timesDone}/{_targetReps} times.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{_title}' already completed.");
        }
    }
}

