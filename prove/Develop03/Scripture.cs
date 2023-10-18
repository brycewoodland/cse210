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
        foreach (Word word in _words)
        {
            word.Hide();
        }
    }

    public void CompletelyHidden()
    {
        
    }
}