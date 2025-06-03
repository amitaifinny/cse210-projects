using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference reference = new Reference("John", "3", 17, 21);
        Reference reference1 = new Reference("Mosiah", "2", 17);
        Scripture text = new Scripture(reference1, "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");


        bool programRunning = true;

        while (programRunning)
        {
            text.ShowScripture();

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                programRunning = false;
            }
            else if (string.IsNullOrEmpty(userInput))
            {
                programRunning = text.HideSomeWords();
            }
        }
    }
}