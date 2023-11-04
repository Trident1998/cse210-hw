class ListingActivity : Activity
{
    private Random _random = new Random();

    private List<String> _promts =  new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int itemsAmount = 0;


    public ListingActivity(String name, String description): base(name, description)
    {
    }

    public void Listen() 
    {
        String promt = _promts[_random.Next(_promts.Count)];

        Console.WriteLine($"List as many responses you can to the following prompt:\n");
        Console.WriteLine($"--- {promt} ---\n");

        Console.Write("You may begin in: ");
        CountDownSeconds(5);
        Console.WriteLine();

        ListResponses();
        
    }

    private void ListResponses() 
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Seconds);

        while (DateTime.Now < endTime) {
            Console.Write(">");
            Console.ReadLine();
            Console.Write("");
            itemsAmount++;
        }
        Console.WriteLine($"You listed {itemsAmount}\n");
    }
}
