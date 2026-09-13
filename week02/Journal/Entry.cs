public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public List<string> _prompts = new List<string>();
    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText} {_entryText}");
    }

    public string GetRandomPrompt()
    {
        _prompts = [
        "Who was the most interesting person interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"];

        var rand = new Random();

        _promptText = _prompts[rand.Next(5)];

        return _promptText;
    }
}