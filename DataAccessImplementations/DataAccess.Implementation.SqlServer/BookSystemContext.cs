using DataAccess.Implementation.SqlServer.Seeds;
using DataAccess.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementation.SqlServer
{
    internal class BookSystemContext:DbContext,IBookSystemContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rewiew> Rewiews { get; set; }
        public DbSet<PromotionalPrice> PromotionalPrices { get; set; }

        public BookSystemContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.AuthorId, ba.BookId });
            modelBuilder.Entity<PromotionalPrice>().HasIndex(x => x.BookId).IsUnique();
            modelBuilder.SeedDatabase();
        }
    }
}
