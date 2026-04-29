// Console-based Library Management System 
using System;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}
class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(string title, string author)
    {
        books.Add(new Book(title, author));
        Console.WriteLine($"Book '{title}' by {author} added to the library.");
    }

    public void BorrowBook(string title)
    {
        var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null && book.IsAvailable)
        {
            book.IsAvailable = false;
            Console.WriteLine($"You have borrowed '{book.Title}'.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{title}' is not available.");
        }
    }

    public void ReturnBook(string title)
    {
        var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null && !book.IsAvailable)
        {
            book.IsAvailable = true;
            Console.WriteLine($"You have returned '{book.Title}'.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{title}' was not borrowed.");
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Library Books:");
        foreach (var book in books)
        {
            string status = book.IsAvailable ? "Available" : "Borrowed";
            Console.WriteLine($"- {book.Title} by {book.Author} [{status}]");
        }
    }
}
class Program
{
    static void Main()
    {
        Library library = new Library();
        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald");
        library.AddBook("To Kill a Mockingbird", "Harper Lee");
        library.AddBook("1984", "George Orwell");

        library.DisplayBooks();

        library.BorrowBook("1984");
        library.DisplayBooks();

        library.ReturnBook("1984");
        library.DisplayBooks();
    }
}

