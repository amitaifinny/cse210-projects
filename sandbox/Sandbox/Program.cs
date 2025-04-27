using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.Write("Input your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your full name is {firstName} {lastName}");


    }
}