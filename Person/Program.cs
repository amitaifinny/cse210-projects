class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("bob", "Lemhi", 20);
        Console.WriteLine(person1.GetPersonInformation());

        PoliceMan newPoliceMan = new PoliceMan("Betty", "crock", 79, "gun");

        Console.WriteLine(newPoliceMan.GetPersonInformation());
        Console.WriteLine(newPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("ben", "kevin", 1, "knife");
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}

