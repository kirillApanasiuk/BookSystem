using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IBookSystemContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rewiew> Rewiews { get; set; }
        public DbSet<PromotionalPrice> PromotionalPrices { get; set; }
        public DbSet<T> Set<T>() where T : class;
        public int SaveChanges();
    }
}
