public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];

        _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());

        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(_duration);

        DisplayPrompt();

        while (DateTime.Now < future)
        {
            DisplayQuestions();
            base.ShowSpinner(7);
        }

        Console.WriteLine("");
        base.DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        var rand = new Random();
        return _prompts[rand.Next(_prompts.Count())];
    }

    public string GetRandomQuestion()
    {
        var rand = new Random();
        return _questions[rand.Next(_questions.Count())];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}