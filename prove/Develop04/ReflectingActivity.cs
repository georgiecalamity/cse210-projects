using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string Name, string Description, int Duration, List<string> Prompts, List<string> Questions) : base(Name, Description, Duration)
    {
        _prompts = Prompts;
        _questions = Questions;
    }

    public override void Run() 
    {
        Start();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine(question);
            Thread.Sleep(10000);
        }
        stopwatch.Stop();
        End();
    }

}