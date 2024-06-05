using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running("10 Jun 2023", 45, 5.2);
        Activity cycling = new Cycling("12 Apr 2023", 40, 10.5);
        Activity swimming = new Swimming("20 Jan 2023", 35, 120.3);

        Activity running2 = new Running("25 Oct 2022", 50, 6.4);
        Activity cycling2 = new Cycling("18 Feb 2023", 55, 14.2);
        Activity swimming2 = new Swimming("28 Mar 2023", 60, 85.9);



        List<Activity> activities = new List<Activity>{running, cycling, swimming,
        running2, cycling2, swimming2};
        foreach(Activity activity in activities){
            Console.WriteLine(activity.GetSummary() +"\n");
        }
    }
}