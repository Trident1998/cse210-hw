class ReflectionActivity : Activity
{
    private Random _random = new Random();

    private List<String> _promts =  new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<String> _question = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public ReflectionActivity(String name, String description): base(name, description)
    {
    }

    public void Reflect() 
    {
        String promt = _promts[_random.Next(_promts.Count)];

        Console.WriteLine($"Consider the following prompt:\n");
        Console.WriteLine($"--- {promt} ---\n");
        Console.WriteLine($"When you have something in mind, press enter to continue.");

        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDownSeconds(5);
        Console.WriteLine();

        DisplayQuestions();
        
    }

    private void DisplayQuestions() 
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Seconds);

        while (DateTime.Now < endTime) {
            string question = _question[_random.Next(_question.Count)];
            Console.Write($"> {question} ");
            GetAnimatins(10);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}