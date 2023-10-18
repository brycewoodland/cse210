using System.ComponentModel.DataAnnotations;

public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string book, string chapter, string verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();
    }

    public void HideWords()
    {
        
    }

    public void CompletelyHidden()
    {
        
    }
}