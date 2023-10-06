using System.Dynamic;

public class Entry 
{
    public string _date;
    public string _prompt;
    public string _journalEntry;

    public Entry(string jp, string userEntry)
    {
        _date = DateTime.Now.ToString();
        _prompt = jp;
        _journalEntry = userEntry;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }
}