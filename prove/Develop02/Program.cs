using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice = 0;

        while (choice != 5)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Select an option: ");

                switch (choice)
                {
                    case 1:
                        string prompt = journal.GetPrompt();
                        Console.WriteLine("Enter your journal entry:");
                        string entryText = Console.ReadLine();
                        journal.AddEntry(prompt, entryText);
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter a filename to save the journal: ");
                        string FileName = Console.ReadLine();
                        journal.SaveToFile(fileName);
                        break;
                    case 4:
                        Console.Write("Enter a filename to load the journal: ");
                        FileName = Console.ReadLine();
                        journal.LoadFromFile(fileName);
                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;                
                }
            }
    }
}