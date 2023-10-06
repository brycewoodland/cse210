using System.IO;

public class Journal 
{
    private List<Entry> _journal = new List<Entry>();

    public void AddToJournal(Entry userEntry)
    {
        _journal.Add(userEntry);
    }

    public void SaveJournalFile(string userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
             foreach (Entry userEntry in _journal)
             {
                outputFile.WriteLine($"{userEntry}");
             }
        }
    }

    public void Display()
    {
        foreach (Entry journalEntry in _journal)
        {
            journalEntry.Display();
        }
    }

    public void LoadJournalFromFile(string userFileName)
    {
        if (File.Exists(userFileName))
        {
            string [] lines = System.IO.File.ReadAllLines(userFileName);

            foreach (string line in lines)
            {
                string [] parts= line.Split(",");

                string date = parts[0];
                string prompt = parts[1];
                string entry = parts[2];
            }
            Console.WriteLine("Journal loaded from the file.");
        }
        else
        {
            Console.WriteLine("File not found. The journal could not be loaded");
        }
    }
}