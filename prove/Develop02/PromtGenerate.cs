class PromtGanarator
{
    private static Random rnd = new Random();

    private List<String> _promtList = new List<String>()
    {
    "What accomplishment today made you feel most proud of yourself?",
    "Did you have a meaningful conversation with someone today? If so, what was it about?", 
    "What small act of kindness did you witness or perform today?",
    "Did you encounter any unexpected challenges today? How did you handle them?",
    "What is one thing you learned today that you didn't know before?",
    "Did you take any steps today towards achieving a personal goal or aspiration? If so, what were they?",
    "Describe a moment today that made you feel grateful or appreciative.",
    "How did you take care of your physical or mental well-being today?",
    "Was there a moment today that made you laugh or smile? What caused it?",
    "Did you make a decision today that you're proud of? What was it?",
    "Did you try something new or step out of your comfort zone today?",
    "Reflect on a moment when you felt truly connected to your surroundings or the world around you today.",
    "Was there a specific event or encounter that left you feeling inspired or motivated?",
    "Did you overcome any fears or doubts today? How did you do it?",
    "What is one thing you would like to do differently tomorrow based on today's experiences?"
    };
    

    public string generatePromt()
    {
        int randomIndexElement = rnd.Next(_promtList.Count);
        return _promtList[randomIndexElement];
    }
}
