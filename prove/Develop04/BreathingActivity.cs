public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing", "This activity will help you relax by walking you through breathing in and breathing out slowly. Clear your mind and focus on your breathing." )
    {
        
    }

    // private void ShowBreathing(int seconds)
    // {
    //     DateTime spinnerLocalEndTime = DateTime.Now.AddSeconds(seconds);
    //     string spinner = "----";

    //     Console.CursorVisible = false;
    //     while (DateTime.Now < spinnerLocalEndTime)
    //     {
    //         Console.WriteLine(spinner[0]);
    //         Thread.Sleep(1000);
    //         Console.Write(spinner[1]);
    //         Thread.Sleep(1000);
    //         Console.Write(spinner[2]);
    //         Thread.Sleep(1000);
    //         Console.Write(spinner[3]);
            
    //     }

    //     Console.CursorVisible = true;
    // }
    public void RunActivity()
    {
        DisplayStartMessage();

        StartTime();

        Console.WriteLine();
        while (HasTimerExpired() == false)
        {
            Console.Write("Breath in...");
            CountDown(3);
            Console.Write("\nNow breath out...");
            CountDown(4);
            Console.WriteLine("\n");
        }
        DisplayEnding();
    }
}