using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write($"What is your username? ");
            string name = Console.ReadLine();
            
            return name;
            
        }

        static int PromptUserNumber()
        {
            Console.Write($"What is your favorite number? ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            
            return favoriteNumber;
        }

        static int SquareNumber(int integer)
        {
            int squared = integer * integer;
            
            return squared;
        }

        static void DisplayResult(string user, int squared)
        {
            Console.WriteLine($"{user}, the square of your number is {squared}");
        }
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);
        
        DisplayResult(userName, squaredNumber);
    }
}