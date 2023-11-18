class SimpleGoal: Goal
{
    private Boolean _isCompleated;

    public SimpleGoal(String name, String description, int increaseAmount): base(name, description, increaseAmount)
    {}

    public SimpleGoal(String name, String description, int increaseAmount, Boolean isCompleated): base(name, description, increaseAmount)
    {
        _isCompleated = isCompleated;
    }

    public SimpleGoal(): base()
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

        return new SimpleGoal(goalName, goalDescription, points);
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{IncreaseAmount},{_isCompleated}";

    }

    public override String DisplaySummary()
    {
        return $"[{GetMark()}] {Name} ({Description})";
    }

    private String GetMark()
    {
        return _isCompleated ? "x" : " ";
    }

    public override void GainePoints()
    {
        Points += IncreaseAmount;
        _isCompleated = true;

        Console.WriteLine($"Congratulations! You have earned {IncreaseAmount} points!");
    }
}
