using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class BookContext : IDb<Book, string>
    {
        private readonly LibraryDbContext dbContext;

        public BookContext(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Book item)
        {
            try
            {
                dbContext.Books.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> ReadAll()
        {
            try
            {
                return dbContext.Books.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Book ReadOne(string id)
        {
            try
            {
                return dbContext.Books.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Book item)
        {
            Book book = dbContext.Books.Find(item.ISBN);
            dbContext.Entry(book).CurrentValues.SetValues(item);
            dbContext.SaveChanges();
        }
        public void Delele(string id)
        {
            try
            {
                Book book = dbContext.Books.Find(id);
                dbContext.Books.Remove(book);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
