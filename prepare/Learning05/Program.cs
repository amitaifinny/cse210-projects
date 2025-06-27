using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 5.0);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("red", 3.0, 4.3);
        shapes.Add(rectangle);

        Circle circle = new Circle("black", 2.75);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has this area: {area}. ");
        }



       
    }
}