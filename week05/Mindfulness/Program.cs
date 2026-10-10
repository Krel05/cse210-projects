using System;

class Program
{
    static void Main(string[] args)
    {
        int option = -1;

        while (option != 4)
        {

            Console.WriteLine("Menu options:");
            Console.WriteLine("   1.- Start breathing activity");
            Console.WriteLine("   2.- Start listing activity");
            Console.WriteLine("   3.- Start reflecting activity");
            Console.WriteLine("   4.- Quit");
            Console.Write("Select a choice from the menu: ");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case 2:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 3:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case 4:
                    break;
            }
        }
    }
}