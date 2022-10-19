using System;
using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;

namespace MovieReviews.Database
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().OwnsMany(user => user.Accounts).HasData(
                new Account
                {
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
                    BalanceRemaining = 4.00
                }
            );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "555-555-5555",
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa")
                }
            );
            /*modelBuilder.Entity<Account>().OwnsMany(account => account.Transactions).HasData(
                new Transaction
                {
                    Amount = 3.00,
                    Date = DateTime.Now,
                    Description = "McDonald",
                    TransactionId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
                }
            );*/
        }
    }
}