using System.ComponentModel;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public Activity()
    {

    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }



    public void ShowSpinner(int seconds)
    {
        // _endTime = DateTime.Now.AddSeconds(seconds);
        DateTime spinnerLocalEndTime = DateTime.Now.AddSeconds(seconds);
        string spinner = "-\\|/";

        Console.CursorVisible = false;
        while (DateTime.Now < spinnerLocalEndTime)
        {
            Console.Write(spinner[0]);
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write(spinner[1]);
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write(spinner[2]);
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write(spinner[3]);
            Thread.Sleep(400);
            Console.Write("\b \b");
        }

        Console.CursorVisible = true;
    }

    public void CountDown(int seconds)
    {
        Console.CursorVisible = false;

        for (int i = seconds; i > 0; i--)
        {
            string numberToDisplay = i.ToString().PadLeft(2);

            Console.Write(numberToDisplay);

            Thread.Sleep(1000);

            Console.Write("\b\b");
        }

        Console.Write("  \b\b");

        Console.CursorVisible = true;
    }


    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);

    }

    public bool HasTimerExpired()
    {
        if (DateTime.Now < _endTime)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


    public void DisplayEnding()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    


}