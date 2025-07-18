using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    protected List<Goal> _goals;
    protected string _filename;
    protected int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    private string ObtainFileName(string prompt)
    {
        Console.WriteLine($"Enter the filename to {prompt}: ");
        return Console.ReadLine();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Points: {_totalScore}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals are: ");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet. Time to create some.");
            return;
        }

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void SaveGoals()
    {
        _filename = ObtainFileName("save");
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
        Console.WriteLine($"Goals saved to {_filename}");
    }

    public void LoadGoals()
    {
        string fileToLoad = ObtainFileName("Load");

        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileToLoad);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty. No score or goals to load.");
            return;
        }

        _totalScore = int.Parse(lines[0]);
        Console.WriteLine($"Loaded score: {_totalScore} points.");

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string goalType = parts[0];
            string goalData = parts[1];

            Goal loadedGoal = null;

            if (goalType == "SimpleGoal")
            {
                string[] goalParts = goalData.Split(',');
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                bool isComplete = bool.Parse(goalParts[3]);
                loadedGoal = new SimpleGoal(name, description, points, isComplete);
            }
            else if (goalType == "EternalGoal")
            {
                string[] goalParts = goalData.Split(',');
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                loadedGoal = new EternalGoal(name, description, points);
            }
            else if (goalType == "CheckListGoal")
            {
                string[] goalParts = goalData.Split(',');
                string name = goalParts[0];
                string description = goalParts[1];
                int points = int.Parse(goalParts[2]);
                int amountCompleted = int.Parse(goalParts[3]);
                int target = int.Parse(goalParts[4]);
                int bonusPoints = int.Parse(goalParts[5]);
                loadedGoal = new CheckListGoal(name, description, points, target, bonusPoints, amountCompleted);
            }

            _goals.Add(loadedGoal);

        }
        Console.WriteLine($"Successfully loaded {_goals.Count} goals from {fileToLoad}");
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Which goal did you accomplish? ");
        int input = int.Parse(Console.ReadLine());


        Goal selectedGoal = _goals[input - 1];

        int goalPoint = selectedGoal.RecordEvent();

        _totalScore += goalPoint;

        DisplayScore();
    }

   
}