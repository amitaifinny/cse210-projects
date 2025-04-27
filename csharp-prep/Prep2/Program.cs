using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);
        
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }

         else if (gradePercentage >= 80)
        {
            letter = "B";
        }

         else if (gradePercentage >= 70)
        {
            letter = "C";
        }

         else if (gradePercentage >= 60)
        {
            letter = "D";
        }

         else if (gradePercentage < 60)
        {
            letter = "F";
        }

        Console.Write($"Your grade is: {letter}.");

        if (gradePercentage >= 70)
        {
            Console.Write(" You passed the class.");
        }

        else
        {
            Console.Write(" You did not pass the class. Next time you totally got it though!");
        }
    }
}