class BreathingActivity : Activity
{
    public BreathingActivity(String name, String description): base(name, description)
    {
    }

    public void BreatheInAndBreathOut() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Seconds);
        Sw.Start();
        double acc = 0.0;
        int i = 1;


        while (acc < endTime.Millisecond)
        {
            acc += DeltaTime();

            if (i == 1) {
                Console.Write("Breathe in...");
                CountDownSeconds(2, acc, endTime.Millisecond);
                Console.WriteLine();
                
                acc += DeltaTime();
                if (acc > endTime.Millisecond) 
                {
                    return;
                }

                Console.Write("Now breathe out...");
                CountDownSeconds(3, acc, endTime.Millisecond);
                Console.WriteLine($"\n");

                i = 0;
                continue;
            }

            acc += DeltaTime();
            if (acc > endTime.Millisecond) 
            {
                return;
            }

            Console.Write("Breathe in...");
            CountDownSeconds(4, acc, endTime.Millisecond);
            Console.WriteLine();

            acc += DeltaTime();
            if (acc > endTime.Millisecond) 
            {
                return;
            }
            Console.Write("Now breathe out...");
            CountDownSeconds(6, acc, endTime.Millisecond);
            Console.WriteLine($"\n");
        }

        Sw.Reset();
    }
}