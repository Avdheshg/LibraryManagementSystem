using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Catalog
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public Book FindBook(string title)
        {
            Book foundBook = _books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            return foundBook;
        }

        public void DisplayAvailableBooks()
        {
            var availableBooks = _books.Where(book => book.IsAvailable).ToList();

            if (availableBooks.Any())
            {
                Console.WriteLine("Available Books");

                foreach (var book in availableBooks)
                {
                    Console.WriteLine($"- {book.Title} by Author: {book.Author}");
                }
            }
            else
            {
                Console.WriteLine("No books are available at the moment");
            }
        }

        public void ShowCatalog()
        {
            foreach (Book book in _books)
            {
                if (book.IsAvailable)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine($"- {book.Title} by Author: {book.Author}");
            }
            Console.ResetColor();
        }

    }
}
