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
        _entryDate = theCurrentTime.ToShortDateString();

        return _entryDate;

    }

    public string GetPrompt()
    {
        PromptGenerator generator = new PromptGenerator();
        _entryPrompt = generator.GetPrompt();

        return _entryPrompt;

    }

    public string GetInput()
    {
        string prompt = GetPrompt();
        Console.Write(prompt);
        _entryInput = Console.ReadLine();

        return _entryInput;

    }

    



    public void Display()
    {
        Console.WriteLine($"Date: {_entryDate} - Prompt: {_entryPrompt}");
        Console.WriteLine(_entryInput);
    }

}

