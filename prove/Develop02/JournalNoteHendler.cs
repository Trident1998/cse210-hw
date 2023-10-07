class JournalNoteHendler
{
    private const int ExludeJournalName = 14;
    private const int ExludeDate = 5;
    private const int ExludePromt = 7;
    private const int ExludeAnswer = 7;


    public void SaveInFile(string filename, JournalNote journal)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Journal name: {journal._title}");
            
            journal._entries.ForEach(entry => outputFile.WriteLine($"Date:{entry._date}~Prompt:{entry._prompt}~Answer:{entry._answer}."));
        }
    }

    public JournalNote ReadJournalFromFile(string filename)
    {
        List<String> lines = new List<String>(System.IO.File.ReadAllLines(filename));
        JournalNote journal = new JournalNote(lines[0].Substring(ExludeJournalName));
        lines.RemoveAt(0);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            string answer = parts[1].Substring(ExludeAnswer);
            string prompt = parts[2].Substring(ExludePromt);

            NoteEntry note = new NoteEntry(answer, prompt);
            note._date = parts[0].Substring(ExludeDate);

            journal._entries.Add(note);
        }    

        return journal;
    }
}
