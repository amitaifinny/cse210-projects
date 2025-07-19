using System.Runtime.CompilerServices;
using System.Security.AccessControl;

public class Menu
{
    private int _input;
    private int _createInput;

    GoalManager goals = new GoalManager();
    public void MakeMenu()
    {

        while (_input != 6)
        {
            
            Console.Clear();
            goals.DisplayScore();
            Console.WriteLine();

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
                    DisplayCreateGoalMenu();
                    Console.WriteLine("Press any key to continue... ");
                    Console.ReadKey();
                    break;
                case 2:
                    goals.DisplayGoals();
                    Console.WriteLine("Press any key to continue... ");
                    Console.ReadKey();
                    break;
                case 3:
                    goals.SaveGoals();
                    Console.WriteLine("Press any key to continue... ");
                    Console.ReadKey();
                    break;
                case 4:
                    goals.LoadGoals();
                    Console.WriteLine("Press any key to continue... ");
                    Console.ReadKey();
                    break;
                case 5:
                    goals.RecordEvent();
                    Console.WriteLine("Press any key to continue... ");
                    Console.ReadKey();
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
        Console.Write("Which type of goal would you like to create? ");
        _createInput = int.Parse(Console.ReadLine());

        switch (_createInput)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                string simpleGoalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string simpleDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with the goal? ");
                int simplePoints = int.Parse(Console.ReadLine());
                SimpleGoal newSimpleGoal = new SimpleGoal(simpleGoalName, simpleDescription, simplePoints, false);
                goals.AddGoal(newSimpleGoal);
                Console.WriteLine($"\nSimple goal {simpleGoalName} created.");

                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                string eternalGoalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string eternalDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with the goal? ");
                int eternalPoints = int.Parse(Console.ReadLine());
                EternalGoal newEternalGoal = new EternalGoal(eternalGoalName, eternalDescription, eternalPoints);
                goals.AddGoal(newEternalGoal);
                Console.WriteLine($"\nEternal goal {eternalGoalName} created.");

                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                string checkListGoalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string checkListDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with the goal? ");
                int checkListPoints = int.Parse(Console.ReadLine());

                Console.Write("How many times does this goal need to be accomplished? ");
                int checkListTarget = int.Parse(Console.ReadLine());

                Console.Write($"What is the bonus for accomplishing {checkListGoalName} {checkListTarget} times? ");
                int checkListBonus = int.Parse(Console.ReadLine());

                CheckListGoal newCheckListGoal = new CheckListGoal(checkListGoalName, checkListDescription, checkListPoints,checkListBonus, checkListTarget, 0);
                goals.AddGoal(newCheckListGoal);
                Console.WriteLine($"\nCheckList goal {checkListGoalName} created.");
                break;
        }

    }
}