using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();;
        while (true)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string numberUser = Console.ReadLine();
            int number = int.Parse(numberUser);
            numbers.Add(number);

            if (number == 0)
            {
                double average = numbers.Average();
                int sumTotal = numbers.Sum();
                int maximum = numbers.Max();
                int minimum = numbers.Min();
                Console.WriteLine($"Sum of the numbers: {sumTotal}");
                Console.WriteLine($"Sum of the numbers: {average}");
                Console.WriteLine($"Sum of the numbers: {maximum}");
                Console.WriteLine($"Sum of the numbers: {minimum}");
                Console.WriteLine($"The sorted list: ");
                numbers.Sort();
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
                break;
            }
        }
    }
}