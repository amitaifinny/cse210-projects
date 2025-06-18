abstract class Person
{
    private string _firstName;
    private string _lastName;

    int _age;

    public Person()
    {
        _firstName = "";
        _lastName = "";
        _age = 0;
    }

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public virtual string GetPersonInformation()
    {
        return $"{_firstName} {_lastName} {_age}";
    }

    public abstract double GetPay();
}