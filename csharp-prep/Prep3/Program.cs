using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        int guessAmount = 0;
        int number = new System.Random().Next(0, 101);

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        
        do {
            guessAmount += 1;
            if (number < guess) {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                continue;
            } else if (number > guess) {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
        } while (number != guess);

        Console.WriteLine($"You guessed it! You have {guessAmount} guesses!");
    }
}