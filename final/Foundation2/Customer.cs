using System.Net.Sockets;

public class Customer
{
    private string _customer;
    private Address _address;

    public Customer(string customer, Address address)
    {
        _customer = customer;
        _address = address;
    }

    public bool HasUsaCitizenship()
    {
        return _address.IsInUsa();
    }

    public string GetCustomerInformation()
    {
        return $"{_customer}\n{_address.GetAddressRepresentation()}";
    }
}