using System.Collections.Generic;
interface IManager{
    Book getBook(BooksLibrary booksLibrary, string bookName);
    List<Book> addBook(BooksLibrary booksLibrary, Book book);
    List<Book> getAllBooks(BooksLibrary booksLibrary);
    string updateBook(BooksLibrary booksLibrary, Book book, string newName);
    void deleteBook(BooksLibrary booksLibrary, string newName);
}