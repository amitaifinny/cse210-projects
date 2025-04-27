using System;
using System.Reflection.Metadata;

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

        if (gradePercentage < 93)

        //Console.Write($"Your grade is: {letter}.");

        if (gradePercentage >= 70)
        {
            Console.Write(" You passed the class.");
        }

        else
        {
            Console.Write(" You did not pass the class. Next time you totally got it though!");
        }

        string sign = "";
        if (letter != "F" && letter != "A")
        {
            int lastDigit = (int)gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.Write($"Your grade is: {letter}{sign}.");
    }
}