using System.Dynamic;

public class Entry 
{
    private string _date = " ";
    private string _prompt = " ";
    private string _journalEntry = " ";

    public Entry()
    {
        
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }
}