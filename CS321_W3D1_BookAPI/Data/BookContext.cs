using System;
using CS321_W3D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace CS321_W3D1_BookAPI.Data
{
    public class BookContext : DbContext
    {
        // TODO: implement a DbSet<Book> property
        public DbSet<Book> Books { get; set; }

        public BookContext(DbContextOptions options) : base(options)
        {
            
        }
      
        // This method runs once when the DbContext is first used.
        // It's a place where we can customize how EF Core maps our
        // model to the database. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: configure some seed data in the books table
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Fellowship of the Ring",
                    Author = "J.R.R. Tolkien",
                    Category = "Fantasy"
                },
                new Book
                {
                    Id = 2,
                    Title = "Glasshouse",
                    Author = "Charles Stross"
                }
                );
            
            base.OnModelCreating(modelBuilder);
            
        }

    }
}

