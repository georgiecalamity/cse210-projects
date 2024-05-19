using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;

    public ListingActivity(string Name, string Description, int Duration, List<string> Prompts) : base(Name, Description, Duration) 
    {
        _prompts = Prompts;
        _items = new List<string>();
    }

    public override void Run() {
        Start();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.WriteLine("Enter: ");
            string item = Console.ReadLine();
            _items.Add(item);
        }
        stopwatch.Stop();
        Console.WriteLine($"You have listed {_items.Count} items");
        End();
    }

}