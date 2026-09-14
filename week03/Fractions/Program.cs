using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        double decimalValue1 = fraction1.GetDecimalValue();
        Console.WriteLine(decimalValue1);

        string fractionString1 = fraction1.GetFractionString();
        Console.WriteLine(fractionString1);

        double decimalValue2 = fraction2.GetDecimalValue();
        Console.WriteLine(decimalValue2);

        string fractionString2 = fraction2.GetFractionString();
        Console.WriteLine(fractionString2);

        double decimalValue3 = fraction3.GetDecimalValue();
        Console.WriteLine(decimalValue3);

        string fractionString3 = fraction3.GetFractionString();
        Console.WriteLine(fractionString3);

    }
}