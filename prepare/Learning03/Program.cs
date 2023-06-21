using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction1.GetDecimalValue()}\n");

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction2.GetDecimalValue()}\n");

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction3.GetDecimalValue()}\n");

        Fraction fraction4 = new Fraction(1, 3); 
        Console.WriteLine($"Fraction 4: {fraction4.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction4.GetDecimalValue()}\n");

        Fraction fraction5 = new Fraction(1, 0); // This will throw an exception
        fraction5.Denominator = 0;
        fraction5.Numerator = 3;
        Console.WriteLine($"Fraction 5: {fraction5.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction5.GetDecimalValue()}\n");
    }
}