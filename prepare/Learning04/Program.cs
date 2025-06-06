using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Bob Kevin", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Senor Wooly", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssingment assignment3 = new WritingAssingment("Sour Strips", "Euroean History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}