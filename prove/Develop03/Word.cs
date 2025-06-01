using System.Net;
using System.Net.NetworkInformation;

public class Word
{
    private bool _hidden;
    private string _word;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
    public void SetIsHidden(bool hidden)
    {
        _hidden = hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    private int GetWordLength()
    {
        return _word.Length;
    }

    public string GetRenderedWord()
    {
        if (_hidden == true)
        {
            return new string('_', GetWordLength());
        }
        else
        {
            return _word;
        }
    }

    public void DisplayWord()
    {
        Console.WriteLine(GetRenderedWord());
    }

}