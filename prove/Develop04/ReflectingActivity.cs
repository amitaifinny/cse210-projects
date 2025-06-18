public class ReflectingActivity : Activity
{
    private List<string> _prompts;

    private List<string> _questions;

    private Random _random;

    public ReflectingActivity()
    : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _random = new Random();

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        StartTime();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine();
        int randomIndexPrompt = _random.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[randomIndexPrompt]}---");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();


        while (!HasTimerExpired())
        {
            Console.WriteLine();
            int randomIndexQuestion = _random.Next(_questions.Count);

            Console.Write($"> {_questions[randomIndexQuestion]} ");
            ShowSpinner(5);

            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEnding();
    }
}