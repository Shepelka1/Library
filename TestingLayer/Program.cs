using BusinessLayer;
using DataLayer;
using ServiceLayer;
using System;

namespace TestingLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Genre genre = new Genre(1, "Fantasy");
            Book book = new Book("nhjytgfre", "test1",5, DateTime.Now, genre);
            Author author = new Author(1, "test", "test2");
            GenresManager genresManager = new GenresManager(new LibraryDbContext());
            BooksManager booksManager = new BooksManager(new LibraryDbContext());
            AuthorsManager authorsManager = new AuthorsManager(new LibraryDbContext());
            GenresManager.Create(genre);
            BooksManager.Create(book);
            AuthorsManager.Create(author);
        }
    }
}
