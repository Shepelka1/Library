using BusinessLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class AuthorContext : IDb<Author, int>
    {
        private readonly LibraryDbContext dbContext;

        public AuthorContext(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Author item)
        {
            try
            {
                dbContext.Authors.Add(item);
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Author> ReadAll()
        {
            try
            {
                return dbContext.Authors.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Author ReadOne(int id)
        {
            try
            {
                return dbContext.Authors.Find(id);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void Update(Author item)
        {
            try
            {
                Author author = dbContext.Authors.Find(item.Id);
                dbContext.Entry(author).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public void Delele(int id)
        {
            try
            {
                Author author = dbContext.Authors.Find(id);
                dbContext.Authors.Remove(author);
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
