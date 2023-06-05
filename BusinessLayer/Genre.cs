using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
{
    public class Genre
    {
        public Genre()
        {
            Books = new List<Book>();
        }

        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
            Books = new List<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        //[ForeignKey("Book")]
        public ICollection<Book> Books { get; set; }
    }
}
