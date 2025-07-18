public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    : base(name, description, points)
    {
        SetGoalType("EternalGoal");
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}:{_name},{_description},{_points}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} from the goal: {_name}");
        return _points;
    }

}