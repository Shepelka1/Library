namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibraryDBElizara : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Nickname = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ISBN = c.String(nullable: false, maxLength: 10),
                        Title = c.String(nullable: false, maxLength: 50),
                        Pages = c.Int(nullable: false),
                        PublishDate = c.DateTime(nullable: false),
                        Genre_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ISBN)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Genre_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_ISBN = c.String(nullable: false, maxLength: 10),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_ISBN, t.Author_Id })
                .ForeignKey("dbo.Books", t => t.Book_ISBN, cascadeDelete: true)
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Book_ISBN)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Books", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.BookAuthors", "Book_ISBN", "dbo.Books");
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Book_ISBN" });
            DropIndex("dbo.Books", new[] { "Order_Id" });
            DropIndex("dbo.Books", new[] { "Genre_Id" });
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Orders");
            DropTable("dbo.Genres");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
