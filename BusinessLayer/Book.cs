using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Book
    {
        public Book()
        {
            Authors = new List<Author>();
            Ganres = new List<Genre>();
        }

        public Book(string iSBN, string title, int pages, DateTime publishDate, Genre genre)
        {
            ISBN = iSBN;
            Title = title;
            Pages = pages;
            PublishDate = publishDate;
            Genre = genre;
            Authors = new List<Author>();
            Ganres = new List<Genre>();
        }

        [Key]
        [MaxLength(10)]
        public string ISBN { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1, 5000)]
        public int Pages { get; set; }

        public DateTime PublishDate { get; set; }

        //[ForeignKey("Genre")]
        public Genre Genre { get; set; }

        //[ForeignKey("Author")]
        public ICollection<Author> Authors { get; set; }
        public ICollection<Genre> Ganres { get; set; }
    }
}
