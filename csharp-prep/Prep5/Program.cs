using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static void PromptUserName(string userName)
        {
            Console.WriteLine($"What is your username");
        }

        static void PromptUserNumber(int favoriteNumber)
        {
            Console.WriteLine($"Your favorite number is: {favoriteNumber}");
        }

        static int SquareNumber(int integer)
        {
            int squared = integer * integer;
            return squared;
        }

        static void DisplayResult()
        {
            Console.WriteLine($"{PromptUserName} the square of your number is {SquareNumber}");
        }
    static void Main(string[] args)
    {
        DisplayWelcome();

    }
}