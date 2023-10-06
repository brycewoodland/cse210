using System.Dynamic;

public class Entry 
{
    private string _date;
    private string _prompt;
    private string _journalEntry;

    public Entry(string jp, string userEntry)
    {
        _date = DateTime.Now.ToString();
        _prompt = jp;
        _journalEntry = userEntry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }
}