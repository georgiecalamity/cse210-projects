using System;

public class WritingAssignments : Assignment
{
    private string _title;

    public WritingAssignments(string Name, string Topic, string Title) : base(Name, Topic)
    {
        _title = Title;
    }

    public string GetWritinInfo() {
        return $"{_studentName} - {_topic}\n{_title} by {_studentName}";
    }

}
