using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", "3", 17, 21);
        Reference reference1 = new Reference("John", "3", 21);
        Word word = new Word("And");

        reference.Display();
        reference1.Display();
    }
}