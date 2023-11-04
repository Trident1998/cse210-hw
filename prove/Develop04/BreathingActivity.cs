class BreathingActivity : Activity
{
    public BreathingActivity(String name, String description): base(name, description)
    {
    }

    public void BreatheInAndBreathOut() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Seconds);

        Console.Write("Breathe in...");
        CountDownSeconds(2);
        Console.WriteLine();

        Console.Write("Now breathe out...");
        CountDownSeconds(3);
        Console.WriteLine($"\n");


        while (DateTime.Now < endTime) {
            Console.Write("Breathe in...");
            CountDownSeconds(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            CountDownSeconds(6);
            Console.WriteLine($"\n");

        }
    }
}