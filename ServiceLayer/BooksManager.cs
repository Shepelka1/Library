using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class BooksManager
    {
        private static BookContext bookContext;
        public BooksManager(LibraryDbContext dbContext)
        {
            bookContext = new BookContext(dbContext);
        }

        public static void Create(Book book)
        {
            try
            {
                bookContext.Create(book);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Book Read(string key)
        {
            try
            {
                return bookContext.ReadOne(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static ICollection<Book> ReadAll()
        {
            try
            {
                return bookContext.ReadAll();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void Update(Book book)
        {
            try
            {
                bookContext.Update(book);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void Delete(string key)
        {
            try
            {
                bookContext.Delele(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
