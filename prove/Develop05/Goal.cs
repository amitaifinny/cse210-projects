using System.ComponentModel;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _goalType;


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public Goal()
    {

    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();

    // public abstract void RunGoal();

    public virtual string GetGoalType()
    {
        return _goalType;
    }

    public virtual void SetGoalType(string type)
    {
        _goalType = type;
    }

    public override string ToString()
    {
        return $"{_name} ({_description}) - {_points} points";
    }

}