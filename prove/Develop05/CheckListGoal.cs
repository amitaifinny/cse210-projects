public class CheckListGoal : Goal
{
    int _bonusPoints;
    int _numberOfCompletions;
    int _maxGoals;
    bool _isComplete;
    public CheckListGoal(string name, string description, int points, int target, int bonusPoints, int amountCompleted)
    : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        // _isComplete = isComplete;
        _maxGoals = target;
        _numberOfCompletions = amountCompleted;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override int RecordEvent()
    {
        return 0;
    }
}