using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibrarySystem;
using System;

namespace LibraryTests
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void AddBook_Test()
        {
            Library lib = new Library();
            Book book = new Book("C# Basics", "John", "123");

            lib.AddBook(book);

            Assert.AreEqual(1, lib.Books.Count);
        }

        [TestMethod]
        public void RegisterBorrower_Test()
        {
            Library lib = new Library();
            Borrower borrower = new Borrower("Sai", "C001");

            lib.RegisterBorrower(borrower);

            Assert.AreEqual(1, lib.Borrowers.Count);
        }

        [TestMethod]
        public void BorrowBook_Test()
        {
            Library lib = new Library();
            Book book = new Book("C# Basics", "John", "123");
            Borrower borrower = new Borrower("Sai", "C001");

            lib.AddBook(book);
            lib.RegisterBorrower(borrower);
            lib.BorrowBook("123", "C001");

            Assert.IsTrue(book.IsBorrowed);
        }

        [TestMethod]
        public void BorrowBook_AssignedToBorrower()
        {
            Library lib = new Library();
            Book book = new Book("C# Basics", "John", "123");
            Borrower borrower = new Borrower("Sai", "C001");

            lib.AddBook(book);
            lib.RegisterBorrower(borrower);
            lib.BorrowBook("123", "C001");

            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [TestMethod]
        public void ReturnBook_Test()
        {
            Library lib = new Library();
            Book book = new Book("C# Basics", "John", "123");
            Borrower borrower = new Borrower("Sai", "C001");

            lib.AddBook(book);
            lib.RegisterBorrower(borrower);
            lib.BorrowBook("123", "C001");
            lib.ReturnBook("123", "C001");

            Assert.IsFalse(book.IsBorrowed);
        }

        [TestMethod]
        public void ReturnBook_RemovedFromBorrower()
        {
            Library lib = new Library();
            Book book = new Book("C# Basics", "John", "123");
            Borrower borrower = new Borrower("Sai", "C001");

            lib.AddBook(book);
            lib.RegisterBorrower(borrower);
            lib.BorrowBook("123", "C001");
            lib.ReturnBook("123", "C001");

            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        [TestMethod]
        public void ViewBooks_Test()
        {
            Library lib = new Library();
            lib.AddBook(new Book("Book1", "A", "1"));
            lib.AddBook(new Book("Book2", "B", "2"));

            var books = lib.ViewBooks();

            Assert.AreEqual(2, books.Count);
        }

        [TestMethod]
        public void ViewBorrowers_Test()
        {
            Library lib = new Library();
            lib.RegisterBorrower(new Borrower("Sai", "C1"));
            lib.RegisterBorrower(new Borrower("Ram", "C2"));

            var borrowers = lib.ViewBorrowers();

            Assert.AreEqual(2, borrowers.Count);
        }
    }
}
