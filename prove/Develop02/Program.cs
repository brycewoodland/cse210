using System;
using System.Runtime.CompilerServices;

Journal bryce = new Journal();
Prompt prompt = new Prompt();

int choice = 0;

while (choice != 5)
{
    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display the journal");
    Console.WriteLine("3. Save the journal to a file");
    Console.WriteLine("4. Load the journal from a file");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option: ");

    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                string jp = prompt.GetPrompt();
                Console.WriteLine(jp);
                Console.Write("Enter your journal entry: ");
                string userEntry = Console.ReadLine();
                Entry entry = new Entry(jp, userEntry);
                bryce.AddToJournal(entry);
                break;
            case 2:
                Console.WriteLine();
                bryce.Display();
                Console.WriteLine();
                break;
            case 3:
                Console.Write("Enter a file name to save the journal: ");
                string fileName = Console.ReadLine();
                bryce.SaveJournalFile(fileName);
                Console.WriteLine("Journal saved to the file.\n");
                break;
            case 4:
                Console.WriteLine("Enter a file name to load to the journal:");
                string loadFileName = Console.ReadLine();
                bryce.LoadJournalFromFile(loadFileName);
                Console.WriteLine("Journal loaded from the file");
                break;
            case 5:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid option. Please choose a valid option.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter a number.");
    }

}
