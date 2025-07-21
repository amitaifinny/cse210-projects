public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email)
    : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string ListShortDetails()
    {
        return $"Event: Reception\n{GetTitle()}\n{GetDate()}";
    }

    public override string GetFullDetails()
    {
        return $"{ListStandardDetails()}\nEvent: Reception\nRSVP: {_email}";
    }
}