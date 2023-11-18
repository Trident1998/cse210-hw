class ChecklistGoal: Goal
{
    private int _extraPoint;
    private int _times;
    private int _goalTimes;
    private Boolean _isCompleated;

    public ChecklistGoal(String name, String description, int increaseAmount, int extraPoint, int goalTimes):
        base(name, description, increaseAmount)
    {
        _extraPoint = extraPoint;
        _goalTimes = goalTimes;
    }

    public ChecklistGoal(String name, String description, int increaseAmount, int extraPoint, int goalTimes, int times):
        base(name, description, increaseAmount)
    {
        _extraPoint = extraPoint;
        _goalTimes = goalTimes;
        _times = times;
        _isCompleated = times >= goalTimes;
    }

    public ChecklistGoal(): base()
    {}

    public override Goal GetInstance()
    {
        String goalName = "";
        String goalDescription = "";
        int points = 0;
        int goalTimes = 0;
        int bonus = 0;

        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        goalTimes = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(goalName, goalDescription, points, bonus, goalTimes);    
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{IncreaseAmount},{_extraPoint},{_goalTimes},{_times}";

    }

    public override void GainePoints()
    {
        _times++;

        if (_times == _goalTimes) 
        {
            Points += _extraPoint + IncreaseAmount;
            _isCompleated = true;
            Console.WriteLine($"Congratulations! You have earned {IncreaseAmount + _extraPoint} points!");
            return;
        }

        Points += IncreaseAmount;
        Console.WriteLine($"Congratulations! You have earned {IncreaseAmount} points!");
    }

    public override String DisplaySummary()
    {
        return $"[{GetMark()}] {Name} ({Description}) -- Currently completed: {_times}/{_goalTimes}";
    }

    private String GetMark()
    {
        return _isCompleated ? "x" : " ";
    }
}
