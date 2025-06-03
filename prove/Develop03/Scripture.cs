using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

public class Scripture
{
    List<Word> _words = new List<Word>();
    Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(' ');


        foreach (string wordString in words)
        {
            Word word1 = new Word(wordString);

            _words.Add(word1);
        }
    }


    public void ShowScripture()
    {
        Console.Clear();

        _reference.Display();

        foreach (Word word in _words)
        {
            word.DisplayWord();
            Console.Write(" ");
        }

    }
    Random random = new Random();
    private int NumberOfHiddenWords()
    {
        int counter = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                counter++;
            }
        }

        return counter;
    }
    public bool HideSomeWords()
    {
        if (NumberOfHiddenWords() == _words.Count)
        {
            return false;
        }

        int wordCounter = 3;

        int wordsHiddenThisRound = 0;

        for (int i = 0; i < wordCounter; i++)
        {
            int randomIndex = random.Next(0, _words.Count);
            Word selectedWord = _words[randomIndex];

            if (!selectedWord.IsHidden())
            {
                selectedWord.Hide();
                wordsHiddenThisRound++;
            }
        }
        return true;
        
    }
}