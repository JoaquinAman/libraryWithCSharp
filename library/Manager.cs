using System;
using System.Collections.Generic;

class Manager : IManager{

    private List<Book> books;

    public Book getBook(BooksLibrary booksLibrary, string bookName){
        List<Book> books = booksLibrary.getBooks();
        Book requestedBook = books.Find(book => String.Equals(book.getTitle(), bookName));
        Console.WriteLine("The requested book is: " + requestedBook.getTitle());
        return requestedBook;
    }
    public List<Book> getAllBooks(BooksLibrary booksLibrary){
        
        List<string> bookNames = new List<string>();
        booksLibrary.getBooks().ForEach(book => bookNames.Add(book.getTitle()));
        Console.WriteLine(string.Join(", ", bookNames));

        // foreach(Book book in booksLibrary.getBooks()){
        //         Console.WriteLine("The book name in the library is: " + book.getTitle());
        //     }
        return booksLibrary.getBooks();
    }

    public List<Book> addBook(BooksLibrary booksLibrary, Book book){
        Console.WriteLine("{0} added", book.getTitle());
        books = booksLibrary.getBooks();
        books.Add(book);
        return books;
    }
    public string updateBook(BooksLibrary booksLibrary, Book book, string newName){
        string oldName = book.getTitle();
        List<Book> books = booksLibrary.getBooks();
        
        List<string> bookNames = new List<string>();
        booksLibrary.getBooks().ForEach(book => bookNames.Add(book.getTitle()));
        int index = bookNames.FindIndex(bookIndex => bookIndex.Contains(oldName));

        Book requestedBook = books.Find(myBook => String.Equals(myBook.getTitle(), book.getTitle()));
        booksLibrary.getBooks().Remove(requestedBook);
        requestedBook.setTitle(newName);
        
        books.Insert(index, requestedBook);
        Console.WriteLine(oldName + " updated to " + requestedBook.getTitle());
        return newName;
    }
    public void deleteBook(BooksLibrary booksLibrary, string bookName){
        List<Book> books = booksLibrary.getBooks();
        Book requestedBook = books.Find(book => String.Equals(book.getTitle(), bookName));
        booksLibrary.getBooks().Remove(requestedBook);
        Console.WriteLine(requestedBook.getTitle() + " succesfully deleted");
    }
}