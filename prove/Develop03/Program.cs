using System;

class Program
{
    static void Main(string[] args)
    {
        Reference a = new Reference("John", "3", "16");
        Console.Clear();
        a.Display();
        Console.WriteLine();
        Console.Write("Press enter to continue or type 'quit' to finish: ");

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "quit")
                break;
        }
    }
}