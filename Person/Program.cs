class Program
{
    public static void Main(string[] args)
    {
        // Person person1 = new Person("bob", "Lemhi", 20);
        // Console.WriteLine(person1.GetPersonInformation());

        PoliceMan newPoliceMan = new PoliceMan("Betty", "crock", 79, "gun", 65, 73.20);

        // Console.WriteLine(newPoliceMan.GetPersonInformation());
        // Console.WriteLine(newPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("ben", "kevin", 1, "knife", 500000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(person1);
        myPeople.Add(myDoctor);
        myPeople.Add(newPoliceMan);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.Write(person.GetPersonInformation());
        Console.WriteLine($"Salary: {person.GetPay()}");
    }
}

