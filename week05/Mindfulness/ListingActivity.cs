public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    private List<string> _thoughts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];


    }

    public void Run()
    {
        base.DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        GetRandomPrompt();
        base.ShowCountDown(10);
        Console.Write("\b\b");
        Console.WriteLine("List your thoughts: ");

        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(_duration);

        while (DateTime.Now < future)
        {
            Console.Write("> ");
            string e = Console.ReadLine();
            _thoughts.Add(e);
            _count++;
        }

        Console.WriteLine("");
        Console.WriteLine($"You wrote {_count} thoughts in {_duration}");
        Console.WriteLine("Your thoughts");
        foreach (var item in GetListFromUser(_thoughts))
        {
            Console.WriteLine($"> {item}");
        }
        base.DisplayEndingMessage();
        Console.WriteLine("");
    }

    public void GetRandomPrompt()
    {
        var rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count())]);
    }

    public List<string> GetListFromUser(List<string> _thoughts)
    {
        List<string> thoughts = _thoughts;

        return thoughts;
    }
}