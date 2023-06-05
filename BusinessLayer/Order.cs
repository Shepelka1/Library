using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
{
    public class Order
    {
        public Order()
        {
            Books = new List<Book>();
        }
        public Order(int id, string username, DateTime dateRecieved, DateTime orderDate)
        {
            Id = id;
            Username = username;
            RecieveDate = dateRecieved;
            OrderDate = orderDate;
            Books = new List<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RecieveDate 
        {
            get
            {
                return this.OrderDate.AddDays(30);
            }
            set { }
        }
        // Navigational property
        //[ForeignKey("Book")]
        public ICollection<Book> Books { get; set; }

    }
}
