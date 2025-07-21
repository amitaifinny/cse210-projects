public class OutdoorGather : Event
{
    private string _weatherForecast;

    public OutdoorGather(string title, string description, string date, string time, Address address, string weatherForecast)
    : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string ListShortDetails()
    {
        return $"Event: Outdoor Gathering\n{GetTitle()}\n{GetDate()}";
    }

    public override string GetFullDetails()
    {
        return $"{ListStandardDetails()}\nEvent: Outdoor Gathering\nProjected Weather Forecast: {_weatherForecast}";
    }

}