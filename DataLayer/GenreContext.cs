using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class GenreContext : IDb<Genre, int>
    {
        private readonly LibraryDbContext dbContext;

        public GenreContext(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Genre item)
        {
            try
            {
                dbContext.Genres.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Genre> ReadAll()
        {
            try
            {
                return dbContext.Genres.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Genre ReadOne(int id)
        {
            try
            {
                return dbContext.Genres.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Genre item)
        {
            try
            {
                Genre genre = dbContext.Genres.Find(item.Id);
                dbContext.Entry(genre).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Delele(int id)
        {
            try
            {
                dbContext.Genres.Remove(dbContext.Genres.Find(id));
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
