using System.ComponentModel;
using System.Transactions;

public class Video {
    
    public List<Comment> _comments = new List<Comment>();
    public string _title;
    public string _author;
    public int _length;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"Comment by {comment.GetNameOfUser()}: {comment.GetCommentText()}");
        }
    }
}