public class Entry 
{
    private string _dateTime = " ";
    private string _journalPrompt = " ";
    private string _journalEntry = " ";

    public Entry(string journalPrompt, string journalEntry)
    {
        _journalPrompt = journalPrompt;
        _journalEntry = journalEntry;
        _dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_journalPrompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }
}