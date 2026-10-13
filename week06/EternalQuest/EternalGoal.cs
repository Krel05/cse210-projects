public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {_points} points.");
        Console.WriteLine("");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"EternalGoal|{_shortName}|{_description}|{_points}";
        return representation;
    }
}