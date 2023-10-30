namespace products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book newBook=null;

            Library library  = new Library();

            char answer;
            do
            {
                Console.WriteLine("1 - Add a book");
                Console.WriteLine("2 - Show all books");
                Console.WriteLine("3 - Get book by Id");
                Console.WriteLine("4 - Sell a book");
                answer = Convert.ToChar(Console.ReadLine());

                switch (answer)
                {
                    case '1':
                        newBook = new();
                        Console.WriteLine("Ad:");
                        newBook.Name = Console.ReadLine();
                        Console.WriteLine("AuthorName:");
                        newBook.AuthorName = Console.ReadLine();
                        Console.WriteLine("Page count:");
                        newBook.PageCount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Price:");
                        newBook.Price = Convert.ToInt32(Console.ReadLine());
                        library.AddBook(newBook);
                        break;
                    case '2':
                        library.ShowAllBooks();
                        break;
                    case '3':
                        Console.WriteLine("Enter Id:");
                        library.GetBookById(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case '4':
                        newBook.Sell();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            } while (answer != 'q');
        }
    }
}