using System.IO;

public class Journal 
{
    public List<Entry> _journal = new List<Entry>();

    public void AddToJournal(Entry userEntry)
    {
        _journal.Add(userEntry);
    }

    public void Display()
    {
        foreach (Entry journalEntry in _journal)
        {
            journalEntry.Display();
        }
    }

    public void SaveJournalFile(string userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
             foreach (Entry userEntry in _journal)
             {
                outputFile.WriteLine($"{userEntry._date} || {userEntry._prompt} || {userEntry._journalEntry} ");
             }
        }
    }

    public void LoadJournalFromFile()
    {
        Console.Write("What is the name of your file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                // Console.WriteLine(line);
                // line will have something like this "Date || Prompt || Entry"
                string[] parts = line.Split(" || ");

                // parts[0] - Date
                // parts[1] - Prompt
                // parts[2] - Entry

                string date = parts[0];
                string prompt = parts[1];
                string entry = parts[2];

                Entry journalEntry = new Entry(prompt, entry);
                journalEntry.SetDate(date);
                AddToJournal(journalEntry);
            }
        }
        else
        {
            Console.WriteLine("File not found. The journal could not be loaded");
        }
    }
}