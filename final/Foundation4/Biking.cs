public class Biking : Activity
{
    private double _speedMph;
    public Biking(string date, double lengthInMinutes, double speedMph)
    : base(date, lengthInMinutes)
    {
        _speedMph = speedMph;
    }

    public override double CalculateDistance()
    {
        return (_speedMph / 60) * GetLengthInMinutes();
    }

    public override double CalculateSpeed()
    {
        return _speedMph;
    }

    public override double CalculatePace()
    {
        return 60 / _speedMph;
    }

}