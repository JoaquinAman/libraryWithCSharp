using System;
using System.Collections.Generic;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Month month = new Month(11);
            Console.WriteLine(month);
            Month month2 = 1;
            Month month3 = (Month)1;
            int myNumber = new Month(13);
            Console.WriteLine(month.MaxValue);


            // IManager manager = new Manager();
            // BooksLibrary booksLibrary = new BooksLibrary();        

            // Book book1 = new Book();
            // book1.setTitle("first book");
            // Book book2 = new Book();
            // book2.setTitle("second book");
            // Book book3 = new Book();
            // book3.setTitle("third book");
           
            // Console.WriteLine("Add: ");
            // manager.addBook(booksLibrary, book1);
            // manager.addBook(booksLibrary, book2);
            // manager.addBook(booksLibrary, book3);
            
            // Console.WriteLine("-------");

            // Console.WriteLine("Get All:");
            // manager.getAllBooks(booksLibrary);

            // Console.WriteLine("-------");

            // Console.WriteLine("Get by Name:");
            // Book myBook = manager.getBook(booksLibrary, "first book");

            // Console.WriteLine("-------");

            // Console.WriteLine("Delete:");
            // manager.deleteBook(booksLibrary, "first book");

            // Console.WriteLine("-------");

            // Console.WriteLine("Get All:");
            // manager.getAllBooks(booksLibrary);
            
            // Console.WriteLine("-------");

            // Console.WriteLine("Update:");
            // manager.updateBook(booksLibrary, book2, "name updated");
            
            // Console.WriteLine("-------");

            // Console.WriteLine("Get All:");
            // manager.getAllBooks(booksLibrary);
        }
    }
}
