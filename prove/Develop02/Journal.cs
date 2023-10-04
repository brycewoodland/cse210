public class Journal 
{
    private List<Entry> _journal = new List<Entry>();

    public Journal()
    {

    }

    public void Display()
    {
        foreach (Entry journalEntry in _journal)
        {
            journalEntry.Display();
        }
    }
}