using System;

class Program
{
    static void Main(string[] args)
    {

        displayMessage();
        string name = userName();
        int number = userNumber();
        string result = displayResult(name,number);
        Console.Write(result);


        static void displayMessage()
        {
            Console.WriteLine("Hello World");
        }

        static string userName()
        {
            Console.Write("Enter name here: ");
            string name = Console.ReadLine();
            return name;
        }

        static int userNumber()
        {
            Console.Write("Enter your favorite number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            return number;
        }

        static string displayResult(string name, int number)
        {
            int square = number * number;
            return $"Brother {name}, the square your number {square}";
        }
    }
}