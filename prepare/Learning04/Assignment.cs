using System;

class Assignment
{

    private String _studentName {get;}
    private String _topic;

    public String StudentName
    {
        get { return _studentName; }
    }

    public Assignment(String studentName, String topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public String GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
