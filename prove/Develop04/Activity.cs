class Activity 
{
    private String _name;
    private String _description;
    private int _seconds; 

    public int Seconds
    {
        get { return _seconds; }
    }

    public Activity(String name, String description)
    {
        _name = name;
        _description = description;
    }

    public void DisplaySammary() 
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");

        _seconds = int.Parse(Console.ReadLine());
    }

    public void DisplayEndMessage() {
        Console.WriteLine($"Well done!!");
        GetAnimatins(5);
        Console.WriteLine($"\nYou have completed another {_seconds} seconds of the {_name} Activity.");
        GetAnimatins(5);
        }


    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        GetAnimatins(5);
        Console.WriteLine($"\n");
    }

    protected void GetAnimatins(int seconds) {
        List<string> animationStrings = new List<string>();
        animationStrings.Add ("|");
        animationStrings.Add ("/");
        animationStrings.Add ("-");
        animationStrings.Add ("\\");
        animationStrings.Add ("|");
        animationStrings.Add ("/");
        animationStrings.Add ("-");
        animationStrings.Add ("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread. Sleep (250);
            Console.Write ("\b \b");

            i++;

            if (i >= animationStrings.Count) {
                i = 0;
            }
        }
    }

    protected void CountDownSeconds(int seconds) {
        do
        {
            Console.Write(seconds);
            Thread. Sleep (1000);
            Console.Write ("\b \b");
            seconds--;

        } while (seconds > 0);
    }
}
