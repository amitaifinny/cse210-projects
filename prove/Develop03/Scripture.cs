using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

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
        Console.WriteLine();
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

        List<Word> unHiddenWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                unHiddenWords.Add(word);
            }
        }

        int wordCounter = 3;
        int wordsHiddenThisRound = 0;

        if (unHiddenWords.Count == 0)
        {
            return false;
        }

        for (int i = 0; i < wordCounter; i++)
        {
            if (unHiddenWords.Count == 0)
            {
                break;
            }

            int randomIndex = random.Next(0, unHiddenWords.Count);

            Word selectedWord = unHiddenWords[randomIndex];

            selectedWord.Hide();

            wordsHiddenThisRound++;

            unHiddenWords.RemoveAt(randomIndex);
    
        }
        return wordsHiddenThisRound > 0;
        // for (int i = 0; i < wordCounter; i++)
        //     {
        //         int randomIndex = random.Next(0, _words.Count);
        //         Word selectedWord = _words[randomIndex];

        //         if (!selectedWord.IsHidden())
        //         {
        //             selectedWord.Hide();
        //             // wordsHiddenThisRound++;
        //         }
        //     }
        // return true;
        
    }
}