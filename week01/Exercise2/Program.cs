using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your grade percentage: ");
        float gradePercentage = float.Parse(Console.ReadLine());

        string grade = "";

        if (gradePercentage >= 90)
        {
            grade = "A";
        }
        else if (gradePercentage >= 80)
        {
            grade = "B";
        }
        else if (gradePercentage >= 70)
        {
            grade = "C";
        }
        else if (gradePercentage >= 60)
        {
            grade = "D";
        }
        else if (gradePercentage < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (gradePercentage >= 70)
        {
            Console.Write("Congratulations! You passed the course!");
        }
        else
        {
            Console.Write("You failed the course. Don't give up! You can do it better next term.");
        }
    }
}