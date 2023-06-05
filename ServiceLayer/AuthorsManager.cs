using System;
using System.Collections.Generic;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class AuthorsManager
    {
        private static AuthorContext authorContext;
        public AuthorsManager(LibraryDbContext dbContext)
        {
            authorContext = new AuthorContext(dbContext);
        }

        public static void Create(Author author)
        {
            try
            {
                authorContext.Create(author);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Author Read(int key)
        {
            try
            {
                return authorContext.ReadOne(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Author> ReadAll()
        {
            try
            {
                return authorContext.ReadAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Update(Author author)
        {
            try
            {
                authorContext.Update(author);
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
                authorContext.Delele(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
