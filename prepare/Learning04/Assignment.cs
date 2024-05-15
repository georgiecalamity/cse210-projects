using System;

public class Assignment{
    protected string _studentName;
    protected string _topic;

    public Assignment(string Name, string Topic) {
        _studentName = Name;
        _topic = Topic;
    }
    public string GetSummary() {
        return $"{_studentName} - {_topic}";
    }
}