using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LibraryDB : Form
    {
        public LibraryDB()
        {
            InitializeComponent();
        }

        private void author_Click(object sender, EventArgs e)
        {
            AuthorMenu authorMenu = new AuthorMenu();
            authorMenu.Show();
        }

        private void LibraryDB_Load(object sender, EventArgs e)
        {

        }

        private void book_Click(object sender, EventArgs e)
        {
            BookMenu bookMenu = new BookMenu();
            bookMenu.Show();
        }

        private void genre_Click(object sender, EventArgs e)
        {
            GenreMenu genreMenu = new GenreMenu();
            genreMenu.Show();
        }

        private void order_Click(object sender, EventArgs e)
        {
            OrderMenu orderMenu = new OrderMenu();
            orderMenu.Show();
        }
    }
}
