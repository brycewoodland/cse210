using System.ComponentModel.DataAnnotations;

public class Reference {
    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _lastVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = verse;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = startVerse;
        _lastVerse = endVerse;
    }

    public void Display()
    {
        if (_firstVerse == _lastVerse)
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
        
    }
}