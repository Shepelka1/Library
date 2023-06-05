using System;
using System.Data.Entity;
using BusinessLayer;

namespace DataLayer
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext() : base("Server = DESKTOP-JQKUPGM\\SQLEXPRESS; Database=LibraryDb;Trusted_Connection=True;")
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
