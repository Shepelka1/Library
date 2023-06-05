using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class GenresManager
    {
        private static GenreContext genreContext;
        public GenresManager(LibraryDbContext dbContext)
        {
            genreContext = new GenreContext(dbContext);
        }

        public static void Create(Genre genre)
        {
            try
            {
                genreContext.Create(genre);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Genre Read(int key)
        {
            try
            {
                return genreContext.ReadOne(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static ICollection<Genre> ReadAll()
        {
            try
            {
                return genreContext.ReadAll();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void Update(Genre genre)
        {
            try
            {
                genreContext.Update(genre);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void Delete(int key)
        {
            try
            {
                genreContext.Delele(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
