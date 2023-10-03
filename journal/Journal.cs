public class Journal 
{
    private string List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string journalEntry)
    {
        Entry entry = new Entry(prompt, journalEntry);
        entries.Add(entry);
    }
}