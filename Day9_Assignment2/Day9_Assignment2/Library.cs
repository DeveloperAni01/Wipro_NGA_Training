using System.Collections.Generic;
using System.Linq;

public class Library
{
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Borrower> Borrowers { get; set; } = new List<Borrower>();

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
        var book = Books.FirstOrDefault(b => b.ISBN == isbn && !b.IsBorrowed);
        var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == cardNumber);

        if (book != null && borrower != null)
        {
            borrower.BorrowBook(book);
        }
    }

    public void ReturnBook(string isbn, string cardNumber)
    {
        var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == cardNumber);
        var book = borrower?.BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

        if (book != null)
        {
            borrower.ReturnBook(book);
        }
    }
}