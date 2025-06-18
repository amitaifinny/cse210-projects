public class Menu
{
    private int _input;
    public void MakeMenu()
    {
        while (_input != 4)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");
            _input = int.Parse(Console.ReadLine());

            switch (_input)
            {
                case 1:
                    BreathingActivity activity1 = new BreathingActivity();
                    activity1.RunActivity();
                    break;
                case 2:
                    ReflectingActivity activity2 = new ReflectingActivity();
                    activity2.RunActivity();
                    break;
                case 3:
                    ListingActivity activity3 = new ListingActivity();
                    activity3.RunActivity();
                    break;
            }
        }
    }
}