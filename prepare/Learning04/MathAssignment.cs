using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studenName, string topic, string textBookSection, string problems) : base(studenName, topic)
    {
        _textbookSection = textBookSection;
        _problems = problems;
    }

  
    public string GetHomeworkList() {
        return $"{_studentName} - {_topic}\n{_textbookSection} - {_problems}";
    }
}