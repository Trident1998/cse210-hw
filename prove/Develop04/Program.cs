using System;

class Program
{
    static void Main(string[] args)
    {
        String choice;
        int breathingAmount = 0;
        int reflectionAmount = 0;
        int listingAmount = 0;


        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();
            Console.Clear();

            switch(choice) 
            {
                case "1":
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                breathing.DisplaySammary();
                breathing.GetReady();
                breathing.BreatheInAndBreathOut();
                breathing.DisplayEndMessage();

                breathingAmount++;
                break;

                case "2":
                ReflectionActivity reflection = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                reflection.DisplaySammary();
                reflection.GetReady();
                reflection.Reflect();
                reflection.DisplayEndMessage();

                reflectionAmount++;
                break;

                case "3":
                ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                listing.DisplaySammary();
                listing.GetReady();
                listing.Listen();
                listing.DisplayEndMessage();

                listingAmount++;
                break;
            }
        } while(choice != "4");

        Console.WriteLine($"\nYou performed {breathingAmount} times of Breathing Activity");  
        Console.WriteLine($"\nYou performed {reflectionAmount} times of Reflection Activity");  
        Console.WriteLine($"\nYou performed {listingAmount} times of Listing Activity");  
    }

}
