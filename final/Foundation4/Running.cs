public class Running : Activity
{
    private double _distance;
    public Running(string date, double lengthInMinutes, double distance)
    : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / GetLengthInMinutes()) * 60;
    }

    public override double CalculatePace()
    {
        return GetLengthInMinutes() / _distance;
    }
}