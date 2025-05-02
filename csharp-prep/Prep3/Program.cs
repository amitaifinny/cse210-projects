using System;
using System.Data;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -10000;

        Console.WriteLine("This is a game about guessing the magic number. Can you win?");

        while (guess != magicNumber)
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }

        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("You guessed the magic number!");
        }
        
        }
    }
}