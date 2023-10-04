using System.Dynamic;

public class Entry 
{
    private string _date = " ";
    private string _prompt = " ";
    private string _journalEntry = " ";

    public Entry(string prompt, string journalEntry)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
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