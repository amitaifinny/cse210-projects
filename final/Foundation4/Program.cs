using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        string date = "July 18, 2025";

        Biking bikingActivity = new Biking(date, 45.0, 15.5);

        Running runningActivity = new Running(date, 30.0, 3.5);

        Swimming swimmingActivity = new Swimming(date, 25.0, 40.0);

        _activities.Add(bikingActivity);
        _activities.Add(runningActivity);
        _activities.Add(swimmingActivity);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

        
    }

    
}