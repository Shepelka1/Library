
namespace PresentationLayer
{
    partial class LibraryDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.author = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.Button();
            this.book = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(229, 156);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(147, 56);
            this.author.TabIndex = 0;
            this.author.Text = "Author";
            this.author.UseVisualStyleBackColor = true;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(229, 329);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(147, 56);
            this.genre.TabIndex = 2;
            this.genre.Text = "Genre";
            this.genre.UseVisualStyleBackColor = true;
            this.genre.Click += new System.EventHandler(this.genre_Click);
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(530, 156);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(147, 56);
            this.book.TabIndex = 3;
            this.book.Text = "Book";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(530, 329);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(147, 56);
            this.order.TabIndex = 4;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(820, 492);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // LibraryDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 650);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.order);
            this.Controls.Add(this.book);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.author);
            this.Name = "LibraryDB";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryDB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button author;
        private System.Windows.Forms.Button genre;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button button5;
    }
}

