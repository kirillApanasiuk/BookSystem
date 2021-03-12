using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Implementation.SqlServer.Seeds
{
    public static class SeedByInitialData
    {
        public static ModelBuilder SeedDatabase(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    DateOfBirth = new DateTime(1999, 05, 24),
                    LastName = "Skit",
                    Name = "John"
                },
                new Author
                {
                    AuthorId = 2,
                    DateOfBirth = new DateTime(1999, 05, 24),
                    LastName = "Spasojevic",
                    Name = "Marinko"
                }

                );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 2,
                    Description = "Book for people who wanted to know c# better",
                    PriceDollar = 20,
                    PublishedOn = new DateTime(2019, 10, 10),
                    Publisher = "Manning",
                    Title = "C# in depth",
                    SoftDeleted = false,
                    ImageUrl = "",
                },
                new Book
                {
                    BookId = 1,
                    Description = "The best book who want to know, about writing api on .net core",
                    PriceDollar = 30,
                    PublishedOn = new DateTime(2020, 2, 14),
                    Publisher = "Code Maze",
                    Title = "Ultimate asp.net core 3 web api",
                    SoftDeleted = false,
                    ImageUrl = "",
                }
                ); ;
            modelBuilder.Entity<Rewiew>().HasData(
                new Rewiew
                {
                    RewiewId = 1,
                    VoterName = "Apanasiuk Kirill",
                    Stars = 5,
                    Comment = "Perfect work!",
                    BookId = 1
                },
                new Rewiew {
                    RewiewId = 2,
                    VoterName = "Apanasiuk Kirill",
                    Stars = 4,
                    Comment = "Not bad, but you have to enough motivation for read it",
                    BookId = 2
                },
                new Rewiew {
                    RewiewId = 3,
                    VoterName = "Peter Bakalov",
                    Stars = 4,
                    Comment = "Sheety book, i wana  programming as a monkey!",
                    BookId = 2
                }
                ); ;
            modelBuilder.Entity<PromotionalPrice>().HasData(
                new PromotionalPrice {
                    PromotionalPriceId = 1,
                    PromotionalText = "The best price ever!",
                    BookId = 1
                },
                new PromotionalPrice
                {
                    PromotionalPriceId = 2,
                    PromotionalText = "Sale!!! Buy book now!",
                    BookId = 2
                }
                );
            modelBuilder.Entity<BookAuthor>().HasData(
                new BookAuthor
                {
                    AuthorId = 1,
                    BookId = 2,
                    Order = 0
                },
                new BookAuthor {
                    AuthorId = 2,
                    BookId = 1,
                    Order = 0
                }
                );
            return modelBuilder;
        }
    }
}
