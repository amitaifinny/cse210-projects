using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    private string _entryDate;
    private string _entryPrompt;

    private string _entryInput;




    private void SetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _entryDate = theCurrentTime.ToShortDateString();

        // return _entryDate;

    }

    private string GetPrompt()
    {
        PromptGenerator generator = new PromptGenerator();
        _entryPrompt = generator.GetPrompt();

        return _entryPrompt;

    }

    public string SetInput()
    {
        SetDate();
        string prompt = GetPrompt();
        Console.Write(prompt);
        _entryInput = Console.ReadLine();

        return _entryInput;

    }

    public string CreateFileString()
    {
        return $"{_entryDate}#{_entryPrompt}#{_entryInput}";
    }

    public void SetAllData(string date, string prompt, string input)
    {
        _entryDate = date;
        _entryPrompt = prompt;
        _entryInput = input;
    }

    



    public void Display()
    {
        Console.WriteLine($"Date: {_entryDate} - Prompt: {_entryPrompt}");
        Console.WriteLine(_entryInput);
    }

}

