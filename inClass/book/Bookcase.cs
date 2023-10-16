using System.ComponentModel.DataAnnotations;
using System.Net;

public class Bookcase
{
    List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void ShowBooks()
    {
        foreach (Book book in _books)
        {
            book.Display();
        }
    }

    public void FindBookByAuthor(string author)
    {
        foreach (Book book in _books)
        {
            if(book.HasAuthor(author))
            {
                book.Display();
            }
        }
    }

    public void CountBooks()
    {
        Console.WriteLine($"We have {_books.Count} books");
    }

    public void ShowPopularBooks(int count)
    {
        count = Math.Min(count, _books.Count);
        Console.WriteLine($"Showing the top {count} popular books");
    }
}