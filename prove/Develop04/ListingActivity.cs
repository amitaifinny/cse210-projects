public class ListingActivity : Activity
{
    private List<string> _listingPrompt;
    private Random _random = new Random();


    public ListingActivity()
    : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

        _listingPrompt = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        StartTime();

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");

        int randomIndexListingPrompt = _random.Next(_listingPrompt.Count);
        Console.WriteLine($"--- {_listingPrompt[randomIndexListingPrompt]} ---");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();

        int itemCount = 0;

        while (!HasTimerExpired())
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items");
    
        DisplayEnding();
    }

}