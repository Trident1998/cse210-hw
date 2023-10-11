using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction fr1 = new Fraction();
        Console.WriteLine($"Empty Constoctor: {fr1.Top}/{fr1.Bottom}");
        Console.WriteLine($"GetFractionString: {fr1.GetFractionString()}");
        Console.WriteLine($"GetDecimalValue: {fr1.GetDecimalValue()}");

        Fraction fr2 = new Fraction(5);
        Console.WriteLine($"One value Constoctor: {fr2.Top}/{fr2.Bottom}");
        Console.WriteLine($"GetFractionString: {fr2.GetFractionString()}");
        Console.WriteLine($"GetDecimalValue: {fr2.GetDecimalValue()}");
    
        Fraction fr3 = new Fraction(3,4);
        Console.WriteLine($"Two value Constoctor: {fr3.Top}/{fr3.Bottom}");
        Console.WriteLine($"GetFractionString: {fr3.GetFractionString()}");
        Console.WriteLine($"GetDecimalValue: {fr3.GetDecimalValue()}");
    }
}