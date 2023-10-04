public class Journal 
{
    private List<Entry> entries = new List<Entry>();
    private string prompt = "Write a journal entry: ";

    public string GetPrompt()
    {
        return prompt;
    }

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {

    }

    public void LoadFromFile(string fileName)
    {

    }

}