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
             
        }
    }

    public void Display()
    {
        foreach (Entry journalEntry in _journal)
        {
            journalEntry.Display();
        }
    }
}