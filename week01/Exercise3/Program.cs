using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = 0;
        do
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Go lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Go higher");
            }
            else
            {
                Console.WriteLine("Correct! You guessed");
                break;
            }
        } while (guess != number);
    }
}