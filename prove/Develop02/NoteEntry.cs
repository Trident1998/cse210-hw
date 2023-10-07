class NoteEntry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _answer;
    public string _prompt;

    public NoteEntry(string answer, string prompt)
    {
        _answer = answer;
        _prompt = prompt;
    }

    public string Display()
    {
        return $"Date: {_date} - Prompt: {_prompt}\nAnswer: {_answer}.";
    }
}
