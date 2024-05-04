using System;
using System.Linq.Expressions;

public class Journal {
    public List<Entry> _entries;
    public PromptGenerator _promptGenerator;

    public Journal() {
        _entries = new List<Entry>();
        _promptGenerator = new PromptGenerator();

    }

    public void AddEntry () {
        string prompt = _promptGenerator.GenerateRandomPrompt();
        Console.WriteLine("Date: ");
        string dateInput = Console.ReadLine();
        Console.WriteLine($"prmpt: {prompt}");
        Console.Write("> ");
        string content = Console.ReadLine();

        Entry newEntry = new Entry(dateInput, content);
        _entries.Add(newEntry);
    }

    public void DisplayEntries() {
        foreach(Entry entry in _entries) {
            entry.DisplayEntries();
        }
    }

    public void SaveToFile() {
        Console.WriteLine("enter desired filename:");
        string filename = Console.ReadLine();
        try {
            using (StreamWriter writer = new StreamWriter(filename)) {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}\n{entry._entryText}");
                }
            }
            Console.WriteLine("saved");
        } catch (Exception e) {
            Console.WriteLine($"error {e.Message}");
        }
    }

    public void LoadFromFile() {
        Console.Write("Filename you would like to laod: ");
        String filename = Console.ReadLine();
        try {
            using (StreamReader reader = new StreamReader(filename)) {
                while (!reader.EndOfStream) {
                    string dateString = reader.ReadLine();
                    string content = reader.ReadLine();
                    Entry entry = new Entry(dateString, content);
                    _entries.Add(entry);
                }
            } 
        } catch (Exception e) {
                Console.WriteLine($"Error loading _entries from :filename: {e.Message}");
        }
    }

}

