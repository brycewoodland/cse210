public class Word {
    private string _word;
    private string _hiddenWord;

    public Word(string word)
    {
        _word = word;
    }

    public string Hide()
    {
        return _hiddenWord;
    }

    public string Show()
    {
        return _word;
    }
}