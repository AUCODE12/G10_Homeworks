using Homework_10_dars.Models;

namespace Homework_10_dars.Services;

public class BookService
{
    private List<Book> books;

    public BookService()
    {
        books = new List<Book>();
    }

    // Add
    public Book AddBook(Book book)
    {
        book.Id = Guid.NewGuid();
        books.Add(book);
        return book;
    }
    public Book AddReaderToBook(Guid bookId, string readerName)
    {
        var requestFromDb = GetBookById(bookId);
        if (requestFromDb is null)
        {
            return null;
        }
        if (!requestFromDb.ReadersName.Contains(readerName))
        {
            requestFromDb.ReadersName.Add(readerName);
        }

        return requestFromDb;
    }
    public Book AddAuthorToBook(Guid bookId, string authorName)
    {
        var requestFromDb = GetBookById(bookId);
        if (requestFromDb is null)
        {
            return null;
        }
        if (!requestFromDb.AuthorsName.Contains(authorName))
        {
            requestFromDb.AuthorsName.Add(authorName);
        }

        return requestFromDb;
    }

    // Read (Get)
    public List<Book> GetBooks()
    {
        return books;
    }
    public Book GetBookById(Guid id)
    {
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }

        return null;
    }
    public Book GetExpensiveBook()
    {
        var newBook = new Book();
        foreach (var book in books)
        {
            if (newBook.Price < book.Price)
            {
                newBook = book;
            }
        }

        return newBook;
    }
    public Book GetMostPagedBook()
    {
        var newBook = new Book();
        foreach (var book in books)
        {
            if (newBook.PageNumber < book.PageNumber)
            {
                newBook = book;
            }
        }

        return newBook;
    }
    public Book GetMostReadBook()
    {
        var newBook = new Book();
        foreach (var book in books)
        {
            if (newBook.ReadersName.Count < book.ReadersName.Count)
            {
                newBook = book;
            }
        }

        return newBook;
    }
    public List<Book> GetBooksByReaderName(string readerName)
    {
        var newReaderbooks = new List<Book>();
        foreach (var book in books)
        {
            if (book.ReadersName.Contains(readerName))
            {
                newReaderbooks.Add(book);
            }
        }

        return newReaderbooks;
    }
    public List<Book> GetBooksByAuthorName(string authorName)
    {
        var newAuthorbooks = new List<Book>();
        foreach (var book in books)
        {
            if (book.AuthorsName.Contains(authorName))
            {
                newAuthorbooks.Add(book);
            }
        }

        return newAuthorbooks;
    }

    // Update 
    public bool UpdateBook(Book book)
    {
        var requestFromDb = GetBookById(book.Id);
        if (requestFromDb is null)
        {
            return false;
        }
        var index = books.IndexOf(requestFromDb);
        books[index] = book;

        return true;
    }

    // Delete
    public bool DeleteBook(Guid id)
    {
        var requestFromDb = GetBookById(id);
        if (requestFromDb is null)
        {
            return false;
        }
        books.Remove(requestFromDb);

        return true;
    }

    // DataSeed
}
