using System;
using System.ComponentModel;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", "3", "16");
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scrip = new Scripture(reference, text);

        do
        {
            scrip.DisplayScripture();
            Console.Write("Press Enter to hide random words or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else
            {
                scrip.HideRandomWord();
            }
        }
        while (true);
    }
}