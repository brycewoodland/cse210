using System;

class Program
{
    static void Main(string[] args)
    {
        Reference a = new Reference("John", "3", "16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        a.Display();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

        string userChoice = " ";
        Console.ReadLine();
        while (userChoice != "quit")
        {
            
        }
    }
}