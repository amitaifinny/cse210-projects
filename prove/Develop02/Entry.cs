using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _entryDate;
    public string _entryPrompt;

    public string GetDate()
    {
        _entryDate = DateTime.Now.ToString("yyyy-MM-dd");
        return _entryDate;

    }

    // public string PromptGenerator()
    // {
        
    // }

    public void Display()
    {
        Console.WriteLine($"{_entryDate}: {_entryPrompt}");
    } 

}