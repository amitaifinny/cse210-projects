public class Menu
{
    private int _input;
    private int _createInput;

    public void MakeMenu()
    {
        while (_input != 6)
        {
            Console.Clear();

            // DisplayScore();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            Console.Write("Select a choice from the menu: ");
            _input = int.Parse(Console.ReadLine());

            switch (_input)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
            }
        }
    }

    public void DisplayCreateGoalMenu()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        _createInput = int.Parse(Console.ReadLine());

        switch (_createInput)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }

    }
}