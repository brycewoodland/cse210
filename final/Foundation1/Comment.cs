using System.Net;

public class Comment {

    public string _commenterName;
    public string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetNameOfUser()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _text;
    }
}