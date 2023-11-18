class EternalGoal: Goal
{
    public EternalGoal(String name, String description, int increaseAmount): base(name, description, increaseAmount)
    {}

    public EternalGoal(): base()
    {}

    public override Goal GetInstance()
    {
        String goalName = "";
        String goalDescription = "";
        int points = 0;

        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());

        return new EternalGoal(goalName, goalDescription, points); 
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{IncreaseAmount}";

    }

    public override String DisplaySummary()
    {
        return $"[ ] {Name} ({Description})";
    }

    public override void GainePoints()
    {
        Points += IncreaseAmount;
        Console.WriteLine($"Congratulations! You have earned {IncreaseAmount} points!");
    }
}
