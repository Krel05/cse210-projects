public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {_points} points.");
        Console.WriteLine("");
        _amountCompleted++;
        if (IsComplete() == true)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        bool completion;

        if (_amountCompleted >= _target)
        {
            completion = true;
        }
        else
        {
            completion = false;
        }

        return completion;
    }

    public override string GetDetailsString()
    {
        string details = $"[ ] {_shortName} ({_description}) -- Currently Complete {_amountCompleted}/{_target}";

        return details;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"SimpleGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
        return representation;
    }
}