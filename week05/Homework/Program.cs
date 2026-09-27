using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment hw = new Assignment("Jorge", "Inheritance");
        Console.WriteLine(hw.GetSummary());

        Console.WriteLine("");

        MathAssignment mhw = new MathAssignment("Sofia", "Derivatives", "3.4", "12-13");
        Console.WriteLine(mhw.GetSummary());
        Console.WriteLine(mhw.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment whw = new WritingAssignment("Carlos", "Best Practices", "Web Best Practices");
        Console.WriteLine(whw.GetSummary());
        Console.WriteLine(whw.GetWritingInformation());
    }
}