using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class NotificationService
    {
        public void SendBorrowNotification(Member member, Book book)
        {
            Console.WriteLine($"{member.Name} has borrowed {book.Title}");
        }

        public void SendReturnNotification(Member member, Book book)
        {
            Console.WriteLine($"{member.Name} has returned {book.Title}");
        }

    }
}
