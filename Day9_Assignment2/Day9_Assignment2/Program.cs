using System;

class Program
{
    static void Main()
    {
        Library lib = new Library();

        Book b = new Book
        {
            Title = "C# Basics",
            Author = "John",
            ISBN = "101"
        };

        Borrower br = new Borrower
        {
            Name = "Rishi",
            LibraryCardNumber = "1"
        };

        lib.AddBook(b);
        lib.RegisterBorrower(br);
        lib.BorrowBook("101", "1");

        Console.WriteLine("Book borrowed successfully!");
    }
}