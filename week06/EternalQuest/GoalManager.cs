using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void Start()
    {
        int option = -1;

        while (option != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu options: ");
            Console.WriteLine("     1.- Create New Goal");
            Console.WriteLine("     2.- List Goals");
            Console.WriteLine("     3.- Save Goals");
            Console.WriteLine("     4.- Load Goals");
            Console.WriteLine("     5.- Record Event");
            Console.WriteLine("     6.- Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals: ");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}.- {goal.GetDetailsString()}");
            index++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Your goals details: ");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}.- {goal.GetDetailsString()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        int option;
        string name;
        string description;
        int points;
        int target;
        int bonus;


        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("     1.- Simple Goal");
        Console.WriteLine("     2.- Etenerl Goal");
        Console.WriteLine("     3.- Checklist Goal");
        Console.Write("What type of Goal would you like to create? ");
        option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:

                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the ammount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());

                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case 2:

                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the ammount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());

                _goals.Add(new EternalGoal(name, description, points));
                break;

            case 3:
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("What is the ammount of points associated with this goal?");
                points = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("What is the bonus for accomplishing it that many times? ");
                bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        int option;

        Console.WriteLine("The goals are: ");
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        option = int.Parse(Console.ReadLine());

        for (int i = 0; i < _goals.Count(); i++)
        {
            if (option - 1 == i)
            {
                _goals[i].RecordEvent();
                _score += _goals[i].GetPoints();
            }
        }
    }

    public void SaveGoals()
    {
        string filename = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score|{GetScore()}");
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = File.ReadAllLines(filename);

        string type;
        string name;
        string description;
        int points;
        bool isComplete;
        int target;
        int bonus;
        int amountCompleted;

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 2)
            {
                type = parts[0];
                _score = int.Parse(parts[1]);
            }
            else if (parts.Length == 5)
            {
                type = parts[0];
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);
                isComplete = bool.Parse(parts[4]);

                SimpleGoal sg = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(sg);
            }
            else if (parts.Length == 4)
            {
                type = parts[0];
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);

                EternalGoal eg = new EternalGoal(name, description, points);
                _goals.Add(eg);
            }
            else if (parts.Length == 7)
            {
                type = parts[0];
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);
                bonus = int.Parse(parts[4]);
                target = int.Parse(parts[5]);
                amountCompleted = int.Parse(parts[6]);

                ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(cg);
            }
        }
    }

    public int GetScore()
    {
        return _score;
    }

}