
namespace LibraryManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a catalog of books
            Catalog catalog = new Catalog();
            catalog.AddBook(new Book("Power of sub-concious mind", "Joseph Murphy"));
            catalog.AddBook(new Book("Think and grow rich", "Napoleon Hill"));
            catalog.AddBook(new Book("C# for dummies", "Harper Lee"));
            catalog.AddBook(new Book("Zen Mind", "Shunryu Suzuki"));

            // create a notification service
            NotificationService notificationService = new NotificationService();

            // Loan manager
            LoanManager loanManager = new LoanManager(catalog, notificationService);

            // Create Members
            Member alice = new Member("Alice");
            Member bob = new Member("Bob");

            // Display available books
            catalog.DisplayAvailableBooks();

            loanManager.BorrowBook(alice, "Power of sub-concious mind");
            //loanManager.BorrowBook(alice, "Power of sub-concious mind");        // in this case : the book is already borrowed, but the notification service will still send the success mess

            loanManager.ShowCatalog();

        }
    }
}


/*
    V can add more features in the catalog 
    V can add colors for available and not available books
    Admin rights:   
        * Admin can see all the books and who borrowed them
        * Normal users will only see that book is borrowed
    
*/
