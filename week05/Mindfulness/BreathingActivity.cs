public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        for (int i = _duration; i > 0; i -= 9)
        {
            Console.Write("Breath in...");
            base.ShowCountDown(4);
            Console.WriteLine("");
            Console.Write("Breath out...");
            base.ShowCountDown(5);
            Console.WriteLine("");
        }
        base.DisplayEndingMessage();
    }
}