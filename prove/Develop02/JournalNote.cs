class JournalNote
{
    public string _title;
    public List<NoteEntry> _entries = new List<NoteEntry>();

    public JournalNote(string title)
    {
        _title = title;
    }

    public void AddEntry(string answer, string prompt)
    {
        _entries.Add(new NoteEntry(answer, prompt));
    }

    public void DisplayEntries()
    {
        Console.WriteLine($"Journal: {_title}");
        foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry.Display()}\n");
        }
    }

        public List<NoteEntry> FindEntryByDate(string date)
    {
        return _entries.Where(it => it._date == date).ToList();
    }
}
