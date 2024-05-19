class Program
{
    static void Main(string[] args)
    {
        List<string> listingPrompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        List<string> reflectionPrompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        List<string> reflectionQuestion = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

        while (true)
        {
            Console.WriteLine("Choose an activity");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your Choice (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("GoodBye");
                break;
            }

            Console.Write("Enter the duration in seconds");
            if(!int.TryParse(Console.ReadLine(), out int duration)) 
            {
                Console.WriteLine("Invalid duration in seconds: ");
                continue;
            }

            Activity activity = choice switch{
                "1" => new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration),
                "2" => new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration, listingPrompts),
                "3" => new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration, reflectionPrompts, reflectionQuestion),
                _ => null
            };

            if (activity != null)
            {
                activity.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between number 1 to 4");
            }
        }
    }   
}