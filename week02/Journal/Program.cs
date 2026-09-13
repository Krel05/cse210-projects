using System;

class Program
{
    static void Main(string[] args)
    {

        int option = -1;
        Journal journal = new Journal();
        string file = "";

        do
        {
            Console.WriteLine("Please, select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Entry entry = new Entry();
                    DateTime date = DateTime.Now;
                    entry._date = date.ToShortDateString();
                    entry._promptText = entry.GetRandomPrompt();
                    Console.WriteLine($"{entry._promptText}");
                    entry._entryText = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Please write the name of the file: ");
                    file = Console.ReadLine();
                    journal.LoadFromFile(file);
                    break;
                case 4:
                    Console.WriteLine("Please write the name of the file: ");
                    file = Console.ReadLine();
                    journal.SaveToFile(file);
                    break;
            }

        } while (option != 5);
    }
}