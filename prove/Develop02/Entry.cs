using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _entryDate;
    public string _entryPrompt;

    public string _entryInput;


    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _entryDate = theCurrentTime.ToShortDateString();
        return _entryDate;

    }

    public string ShowPrompt()
    {
        PromptGenerator generator = new PromptGenerator();

        _entryPrompt = generator.GetPrompt();

        return _entryPrompt;

    }

    public string GetInput()
    {
        Console.WriteLine(ShowPrompt());
        string input = Console.ReadLine();
        _entryInput = input;
        return _entryInput;
    }



    public void Display()
    {
        Console.WriteLine($"Date: {GetDate()}- Prompt: {GetInput()}");
    }

}

