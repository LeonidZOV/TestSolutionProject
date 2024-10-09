

public class Program
{
    public static void Main(string[] args) { }
}

public class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }
}

public class Library()
{
    private List<Book> books = new List<Book>();

    public bool AddBook(Book book)
    {
        books.Add(book);
        return true;
    }

    public bool HasBook(Book book)
    {
        bool result = books.Contains(book);
        return result;
    }

    public bool RemoveBook(Book book) 
    {
        books.Remove(book);
        return true;
    }

    public bool HasNotBook(Book book) 
    { 
        bool result = books.Contains(book);
        return !result;
    }
}

public class Reader()
{
    private List<Book> books = new List<Book>();

    public bool GetBookFromLibrary(Book book, Library library)
    {
        //throw new NotImplementedException();//
        books.Add(book);
        library.RemoveBook(book);
        return true;
    }

    public bool ReturnBookToLiabrary(Book book, Library library)
    {
        //throw new NotImplementedException();//
        books.Remove(book);
        library.AddBook(book);
        return true;
    }
}