public class CheckListGoal : Goal
{
    protected int _bonusPoints;
    protected int _amountCompleted;
    protected int _target;
    public CheckListGoal(string name, string description, int points, int target, int bonusPoints, int amountCompleted)
    : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _target = target;
        _amountCompleted = amountCompleted;
        SetGoalType("CheckListGoal");
    }

    public CheckListGoal()
    {

    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}:{_name},{_description},{_points},{_bonusPoints},{_target},{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted >= _target)
        {
            return $"[X] {_name} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }

    }

    public override int RecordEvent()
    {
        int PointsEarnedThisEvent = _points;

        Console.WriteLine($"\nCongratulations! You have earned {_points} points for '{_name}'.");

        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            PointsEarnedThisEvent += _bonusPoints;
            Console.WriteLine($"Congratulations, you checked all the steps to this goal! You earned an additional {_bonusPoints} bonus points");
        }

        Console.WriteLine($"Current progress: {_amountCompleted}/{_target}");

        return PointsEarnedThisEvent;
    }

    // private void Obtaintarget()
    // {

    // }

    // private void ObtainBonusPoints()
    // {

    // }
}