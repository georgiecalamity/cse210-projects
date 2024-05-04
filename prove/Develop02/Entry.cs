using System;

public class Entry {

    public string _date;
    public string _entryText;

    public Entry(string dateInput, string content) {
        _date = dateInput;
        _entryText = content;
    }

    public void DisplayEntries() {
        Console.WriteLine($"date: {_date}");
        Console.WriteLine($"Content: {_entryText}");
    }
}