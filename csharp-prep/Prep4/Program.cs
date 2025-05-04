using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Enter '0' when done.");
        
        int numberInput = -1;        
        List<int> numbers = new List<int>();
        
        while (numberInput != 0)
        {
        Console.Write("Enter number: ");
        numberInput = int.Parse(Console.ReadLine());
        

        if (numberInput != 0)
        {
            numbers.Add(numberInput);
        }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"This is the sum: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }        
        Console.WriteLine($"The largest number is: {largestNumber}");

        // Console.WriteLine(numbers.Count);
    }
}