using System.Dynamic;

public class Entry 
{
    private string _date = { get; };
    private string _journalPrompt = { get; };
    private string _journalEntry = { get; };

    public Entry(string date, string prompt, string journalEntry)
    {
        _date = date;
        _prompt = prompt;
        _journalEntry = journalEntry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }
}