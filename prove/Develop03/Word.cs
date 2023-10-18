public class Word {
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public string Show()
    {
        return _text;
    }

    public bool isHidden()
    {
        return _hidden;
    }

    public string GetText()
    {
        return _text;
    }
}