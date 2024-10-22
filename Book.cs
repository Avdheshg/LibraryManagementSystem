using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsAvailable { get; private set; } = true;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Borrow()
        {
            // check if book is available
            if (IsAvailable == true)
            {
                IsAvailable = false;
                Console.WriteLine($"Book: {Title} of Author: {Author} is borrowed");
            }
            else
            {
                Console.WriteLine($"Not Available: Book: {Title} of Author: {Author} already taken by someone else.");
            }
        }

        public void Return()
        {
            // check if book is Available
            if (IsAvailable == false)
            {
                IsAvailable = true;
                Console.WriteLine($"Book: {Title} of Author: {Author} is returned");
            }
        }

    }
}
