using System;
using System.Runtime.CompilerServices;

Journal bryce = new Journal();
Prompt prompt = new Prompt();

int choice = 0;

while (choice != 5)
{
    Console.WriteLine("***************************");

    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display the journal");
    Console.WriteLine("3. Save the journal to a file");
    Console.WriteLine("4. Load the journal from a file");
    Console.WriteLine("5. Exit");
    Console.WriteLine("Select an option:");
    Console.WriteLine();

    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                string jp = prompt.GetPrompt();
                Console.WriteLine(jp);
                Console.WriteLine("Enter your journal entry:");
                string userEntry = Console.ReadLine();
                Entry entry = new Entry(jp, userEntry);
                Console.WriteLine("**********************");
                bryce.AddToJournal(entry);
                break;
            case 2:
                bryce.Display();
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
