using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        String name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(SquareNumber(number), name);
    }


    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(int number, String name)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}