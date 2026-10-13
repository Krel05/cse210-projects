public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You earned {_points} points.");
        Console.WriteLine("");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";

        return representation;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}