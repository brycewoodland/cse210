class Program 
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool isRunning = true;

        while (isRunning)
        {
            while (isRunning)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Select an option: ");

                string choice = Console.ReadLine();
            }
        }
    }
}