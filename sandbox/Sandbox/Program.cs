using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        int y = 2;
        int z = 5;
        
        if (!(x > y || x < y) && y < z)
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