using System.Reflection;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public abstract string ListShortDetails();

    public abstract string GetFullDetails();
    public string ListStandardDetails()
    {
        return $"{_title}\n{_description}\nWhen: {_date} at {_time}\nLocation: {_address.GetAddressRepresentation()}";
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }

    public void SetTime(string time)
    {
        _time = time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

}