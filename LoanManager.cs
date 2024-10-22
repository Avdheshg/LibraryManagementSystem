using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LoanManager
    {
        private readonly Catalog _catalog;
        private readonly NotificationService _notificationService;

        public LoanManager(Catalog catalog, NotificationService notificationService)
        {
            _catalog = catalog;
            _notificationService = notificationService;
        }

        public void BorrowBook(Member member, string bookTitle)
        {
            // check if Catalog have this book or not
                // call the book.borrow
                // tell the notificationService to notify
            Book foundBook = _catalog.FindBook(bookTitle);

            if (foundBook != null)
            {
                foundBook.Borrow();
                _notificationService.SendBorrowNotification(member, foundBook);
            }
            else
            {
                Console.WriteLine($"The book: {bookTitle} is not available for borrowing");
            }
        }

        public void ReturnBook(Member member, string bookTitle)
        {
            // search for the book
            // call book.return
            // tell the notificationService to notify

            Book foundBook = _catalog.FindBook(bookTitle);

            if (foundBook != null)
            {
                foundBook.Return();
                _notificationService.SendReturnNotification(member, foundBook);
            }
            else
            {
                Console.WriteLine($"The book: {bookTitle} is not currently borrowed");
            }
            
        }

        public void ShowCatalog()
        {
            _catalog.ShowCatalog();
        }

    }
}
