using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 6;

        
        

        while (true){
            Console.Write("What is the magic number: ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);
        
            if (guessNumber > magicNumber){
                Console.WriteLine("lower");
            }
            else if (guessNumber < magicNumber){
                Console.WriteLine("higher");
            }
            else{
                Console.WriteLine("you guessed it");
                break;
            }
        }
    }
}