using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{

    public BreathingActivity(string Name, string Description, int Duration) : base(Name, Description, Duration) { }

    public override void Run()
    {
        Start();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            if ((int)stopwatch.Elapsed.TotalSeconds % 8 < 4)
            {
                Console.WriteLine("Breath in...");
            }
            else
            {
                Console.WriteLine("Breath out...");
            }
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"\r{i}");
                Thread.Sleep(1000);
                Console.Write("\b");
            }
        }
        stopwatch.Stop();
        End();
        

    }
}