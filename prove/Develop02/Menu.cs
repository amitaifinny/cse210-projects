using System.ComponentModel.DataAnnotations;

public class Menu
{
    int _userInput;
    public void MakeMenu()
    {
        Journal journal = new Journal();
        while (_userInput != 6)
        {
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Unique Words");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            _userInput = int.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1:
                    Entry entry = new Entry();
                    entry.SetInput();
                    journal.AddEntry(entry);
                    break;

                case 2:
                    WordGenerator word = new WordGenerator();
                    word.Display();
                    break;

                case 3:
                    journal.DisplayEntries();
                    break;

                case 4:
                    journal.ReadFromFile();
                    break;

                case 5:
                    journal.WriteToFile();
                    break;
            }
        }


    }

}
