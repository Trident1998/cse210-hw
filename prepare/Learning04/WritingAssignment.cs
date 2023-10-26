using System;

class WritingAssignment : Assignment
{
    private String _titel;

    public WritingAssignment(String studentName, String topic, String titel) : base(studentName, topic)
    {
        _titel = titel;
    }

    public String GetWritingInformation()
    {
        return $"{_titel} by {StudentName}";
    }
}
