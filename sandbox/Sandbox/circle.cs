// class Program
// {
    
    class Circle
    {
        private double _radius;

        public void SetRadius(double radius)
        {
           if (radius < 0)
           {
            Console.WriteLine("Error, radius must > 0");
           }
        //    return;
            _radius = radius;
        }

        public double GetRadius()
        {
            return _radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
        // Console.WriteLine("Bonjour tout le monde");
        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(99);
        // myNumbers.Add(25);
        // myNumbers.Add(-135);
        // // myNumbers.Append(20);

        // foreach(int i in myNumbers)
        // {
        //     Console.WriteLine(i);
        // }

    //    int x = 10;
    //    if (x==10)
    //    {
    //     Console.WriteLine("x is 10");

    //    }

    //    Console.WriteLine("Hey how are you?");
       
    //    Console.WriteLine("Another test");

    //    for(int i = 0; i < 20; i++)
    //    {
    //     Console.WriteLine($"Hello Bob {i}");
    //    }
        // double total = AddNumbers(123.98, 985.12356);
        // Console.WriteLine(total);

        // bool done = false;
        // while(!done)
        // {
        //     done = true;
        // }

        // // do will always run at least once

        // do
        // {

        // } while(!done);

    // }

    // static double AddNumbers(double a, double b)
    // {
    //     return a + b;
    // }