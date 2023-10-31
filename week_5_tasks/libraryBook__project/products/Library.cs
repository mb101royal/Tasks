namespace products;
internal class Library
{
    Book[] _books = new Book[0];

    public void AddBook(Book book)
    {
        Array.Resize(ref _books, _books.Length + 1);
        _books[_books.Length - 1] = book;
    }

    public string GetBookById(int id)
    {
        if (id >= 0 && id < _books.Length - 1)
            foreach (var book in _books)
            {
                if (id == book.Id)
                {
                    return book.ShowInfo();
                } 
            }
        return "Invalid index.";
    }
    public void ShowAllBooks()
    {
        if (_books.Length > 0)

            foreach (var book in _books)
            {
                Console.WriteLine(book.ShowInfo());
            }
        else Console.WriteLine("Kitabxana bosdur.");
    }
}
