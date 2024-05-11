using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture(new Reference("John", 3, 16, 17), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
        Console.WriteLine(scripture.getDisplayText());
        
        Console.WriteLine("Press Enter to hide random words, or type 'quit' to end the program.");
        while (true)
        {
            var userInput = Console.ReadLine();
            if (userInput == "quit")
                break;

            scripture.HideRandomWords(new Random().Next(1, 6));
            Console.WriteLine(scripture.getDisplayText());

            if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words in the scripture are hidden. Ending the program.");
            break;
        }
        }
        
    }
}
