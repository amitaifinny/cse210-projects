public class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete)
    : base(name, description, points)
    {
        _isComplete = isComplete;

        SetGoalType("SimpleGoal");
    }

    public SimpleGoal()
    {

    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("Goal already complete. No points awarded.");
            return 0;
        }
        else
        {
            _isComplete = true;

            Console.WriteLine($"\nCongratulations! You have successfully completed the goal '{_name}' and earned {_points} points!");
            return _points;
        }
    }

    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}:{_name},{_description},{_points},{_isComplete}";
    }

}