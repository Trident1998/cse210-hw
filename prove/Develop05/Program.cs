using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalHandler handler = new GoalHandler();
        List<Goal> goals = new List<Goal>();
        String choice = "";


        do
        {
            int sum = goals.Select(goal => goal.Points).Sum();
            int i = 1;

            Console.WriteLine($"You have {sum} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch(choice) 
            {
                case "1":
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");

                choice = Console.ReadLine();

                switch(choice) 
                {
                    case "1":
                    Goal simple = new SimpleGoal().GetInstance();
                    goals.Add(simple);
                    Console.WriteLine();
                    break;

                    case "2":
                    Goal eternal = new EternalGoal().GetInstance();
                    goals.Add(eternal);
                    Console.WriteLine();
                    break;

                    case "3":
                    Goal checkList = new ChecklistGoal().GetInstance();
                    goals.Add(checkList);
                    Console.WriteLine();
                    break;
                }
                break;

                case "2":
                Console.WriteLine("The goals are:");

                goals.ForEach(goal => {
                    Console.WriteLine($"{i}. {goal.DisplaySummary()}");
                    i++;
                });
                Console.WriteLine();
                break;

                case "3":
                Console.Write("What is the file name for the goal file? ");
                String fileName = Console.ReadLine();

                handler.SaveFile(goals, fileName);
                Console.WriteLine();
                break;

                case "4":
                Console.Write("What is the file name for the goal file? ");
                String loadFileName = Console.ReadLine();
                
                KeyValuePair<int, List<Goal>> keyValuePair = handler.LoadFile(loadFileName);

                sum = keyValuePair.Key;
                goals = keyValuePair.Value;
                Console.WriteLine();
                break;

                case "5":
                Console.WriteLine("The goals are:");
                goals.ForEach(it =>{
                    Console.WriteLine($"{i}. {it.Name}");
                    i++;
                });

                Console.Write("Wich goal did you accomplish? ");
                int goalIndex = int.Parse(Console.ReadLine());

                Goal goal = goals[goalIndex - 1];
                goal.GainePoints();

                Console.WriteLine($"You now have {goal.IncreaseAmount + sum} points.\n");
                break;
            }
        } while(choice != "6");
    }
}
