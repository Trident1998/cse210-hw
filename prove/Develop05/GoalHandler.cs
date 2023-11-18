using System.Text.Json;
using System.Threading.Tasks.Dataflow;

class GoalHandler
{
    public void SaveFile(List<Goal> goals, String fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int sum = goals.Select(goal => goal.Points).Sum();
            outputFile.WriteLine($"{sum}");

            goals.ForEach(goal => {
            outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            });
        }
    }

    public KeyValuePair<int, List<Goal>> LoadFile(String fileName)
    {
        List<String> lines = new List<String>(System.IO.File.ReadAllLines(fileName));
        List<Goal> goals = new List<Goal>();
        int pointsSum = int.Parse(lines[0]);
        lines.RemoveAt(0);

        foreach (string line in lines)
        {
            string[] data =  line.Split(':');
            string[] parts = data[1].Split(",");


            switch(data[0])
            {
                case "SimpleGoal":
                SimpleGoal simpleGoal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                goals.Add(simpleGoal);
                break;

                case "EternalGoal":
                EternalGoal eternalGoal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                goals.Add(eternalGoal);
                break;

                case "ChecklistGoal":
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                goals.Add(checklistGoal);
                break;                
            }
        }    

        return new KeyValuePair<int, List<Goal>>(pointsSum, goals);   
    }
}