using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        int y = 2;

        
        if (x > y)
        {
            Console.WriteLine("greater");
        }
        else if (x < y)
        {
            Console.WriteLine("less");
        }
        else
        {
            Console.WriteLine("equal");
        }
    }
}