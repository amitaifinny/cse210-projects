using System.Collections.Concurrent;
using System.Security.Cryptography;

public class Reference
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, string chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = -1;
    }

    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void Display()
    {
        if (_endVerse == -1)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
        }
    }
}