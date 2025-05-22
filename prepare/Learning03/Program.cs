using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(5);
        Fraction fraction2 = new Fraction(3, 4);
        Fraction fraction3 = new Fraction(1, 3);

        // fraction1.SetTop(2);
        // int topNumber = fraction1.GetTop();
        // fraction1.SetBottom(3);
        // int bottomNumber = fraction1.GetBottom();
        // Console.WriteLine($"{topNumber}/{bottomNumber}");

        // int kevin = fraction.GetBottom();
        // Console.WriteLine(kevin);

        // int s = fraction2.GetTop();
        // int a = fraction2.GetBottom();


        Console.WriteLine(fraction.GetFractionString());

        Console.WriteLine(fraction.GetDecimalValue());


        Console.WriteLine(fraction1.GetFractionString());

        Console.WriteLine(fraction1.GetDecimalValue());


        Console.WriteLine(fraction2.GetFractionString());

        Console.WriteLine(fraction2.GetDecimalValue());


        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine(fraction3.GetDecimalValue());
    }

}