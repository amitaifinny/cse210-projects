public abstract class Activity
{
    private string _date;
    private double _lengthInMinutes;

    public Activity(string date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }



    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public double GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public void SetLength(double lengthInMinutes)
    {
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual string GetSummary()
    {
        string activityType = this.GetType().Name;
        return $"{_date} {activityType}({_lengthInMinutes} min)- Distance: {CalculateDistance():F1} miles, Speed {CalculateSpeed():F1} mph, Pace: {CalculatePace():F1} min per mile.";
    }
    

}