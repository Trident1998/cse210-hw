using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your scale: ");
        int scale = int.Parse(Console.ReadLine());
        string letterGrade = "";
        switch(scale) 
        {
            case >= 90:
                letterGrade = "A";
                break;
            case >= 80:
                letterGrade = "B";
                break;
            case >= 70:
                letterGrade = "C";
                break;
            case >= 60:
                letterGrade = "D";
                break;
            default:
                letterGrade = "F";
                break;
        }

        if (scale >= 70) 
        {
            Console.WriteLine($"Congratulation you have passed the coursee! Your grade is {letterGrade}!");
        }
        else 
        {
            Console.WriteLine($"Unforthunatly you have not passed the coursee! Your grade is {letterGrade}!");
        }
    }
}