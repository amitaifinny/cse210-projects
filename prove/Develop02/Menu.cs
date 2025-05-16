using System.ComponentModel.DataAnnotations;

public class Menu
{
    int _userInput;
    public void MakeMenu()
    {
        while (_userInput != 5)
        {
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            _userInput = int.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1:
                    Entry entry = new Entry();
                    entry.GetInput();

                    break;

                case 2:
                    Journal display = new Journal();
                    display.DisplayEntries();
                    break;
            }
        }


    }

}
