public class Swimming : Activity
{
    private double _numberOfLaps;
    public Swimming(string date, double lengthInMinutes, double numberOfLaps)
    : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double CalculateDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }

    public override double CalculateSpeed()
    {
        return (CalculateDistance() / GetLengthInMinutes()) * 60;
    }

    public override double CalculatePace()
    {
        return GetLengthInMinutes() / CalculateDistance();
    }
}