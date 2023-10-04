using System.Dynamic;

public class Entry 
{
    private string _date = " ";
    private string _prompt = " ";
    private string _journalEntry = " ";

    public Entry(string prompt)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _prompt = prompt;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

       public string GetJournalEntry()
    {
        return _journalEntry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }
}