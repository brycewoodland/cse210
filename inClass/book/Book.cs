using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

public class Book 
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string name, string author) 
    {
        _timesRead = 0;
        _available = true;
        _name = name;
        _author = author;
    }

    public bool HasAuthor(string authorName)
    {
        return _author.Contains(authorName);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Times Read: {_timesRead}");
        Console.WriteLine($"Available: {_available}");
    }

    public bool IsAvailable()
    {
        return _available;
    }

    public int TimesRead()
    {
        return _timesRead;
    }

    public void CheckOut()
    {
        _timesRead += 1;
        _available = false;
    }

    public void CheckIn()
    {
        _available = true;
    }
}
