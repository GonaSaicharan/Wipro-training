using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Borrower> Borrowers { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string cardNumber)
        {
            Book book = Books.First(b => b.ISBN == isbn);
            Borrower borrower = Borrowers.First(b => b.LibraryCardNumber == cardNumber);

            book.Borrow();
            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string cardNumber)
        {
            Book book = Books.First(b => b.ISBN == isbn);
            Borrower borrower = Borrowers.First(b => b.LibraryCardNumber == cardNumber);

            book.Return();
            borrower.ReturnBook(book);
        }

        public List<Book> ViewBooks()
        {
            return Books;
        }

        public List<Borrower> ViewBorrowers()
        {
            return Borrowers;
        }
    }
}
