using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public Author(int id, string name, string nickname)
        {
            Id = id;
            Name = name;
            Nickname = nickname;
            Books = new List<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Nickname { get; set; }

        //[ForeignKey("Book")]
        public ICollection<Book> Books { get; set; }
    }
}
