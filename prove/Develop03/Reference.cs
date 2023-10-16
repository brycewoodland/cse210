using System.ComponentModel.DataAnnotations;

public class Reference {
    private string _book;
    private string _chapter;
    private string _verse;
    private string _text;

    public Reference(string book, string chapter, string verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse} {_text}");
    }
}