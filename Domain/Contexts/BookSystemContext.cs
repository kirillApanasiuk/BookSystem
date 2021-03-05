using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Contexts
{
    public class BookSystemContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<PromotionalPrice> PromotionalPrices { get; set; }

        public BookSystemContext(DbContextOptions options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<BookAuthor>().HasKey(x => new { x.AuthorId, x.BookId });
        }
    }
}
