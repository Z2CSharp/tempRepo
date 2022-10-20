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
            modelBuilder.Entity<User>().HasKey(u => u.UserId);
            modelBuilder.Entity<Account>().HasKey(a => a.AccountId);
            modelBuilder.Entity<Transaction>().HasKey(t => t.TransactionId);

            modelBuilder.Entity<User>().HasData(
                new User{
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "555-555-5555",
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa")
                }
            );

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
                    BalanceRemaining = 4.00
                },
                new Account
                {
                    AccountId = new Guid("d5e17d64-6f1a-4ce0-834d-2fd367e273ca"),
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
                    BalanceRemaining = 10.00
                }
            );

            // modelBuilder.Entity<PostTag>()
            //     .HasOne(pt => pt.Post)
            //     .WithMany(p => p.PostTags)
            //     .HasForeignKey(pt => pt.PostId);

            modelBuilder.Entity<Transaction>()
            .HasData(
                new Transaction
                {
                    Amount = 3.00,
                    Date = DateTime.Now,
                    Description = "McDonald",
                    TransactionId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
                },
                new Transaction
                {
                    Amount = 5.00,
                    Date = DateTime.Now,
                    Description = "Wendy",
                    TransactionId = new Guid("642ca94b-e714-4e60-b3ce-feab46a461b0"),
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
                }
            );




            // modelBuilder.Entity<User>().HasData(
            //     new User
            //     {
            //         FirstName = "John",
            //         LastName = "Doe",
            //         Phone = "555-555-5555",
            //         UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa")
            //     }
            // );

            // modelBuilder.Entity<Account>().HasData(
            //     new Account
            //     {
            //         AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
            //         UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
            //         BalanceRemaining = 4.00
            //     },
            //     new Account
            //     {
            //         AccountId = new Guid("d5e17d64-6f1a-4ce0-834d-2fd367e273ca"),
            //         UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
            //         BalanceRemaining = 10.00
            //     }
            // );

            // modelBuilder.Entity<Transaction>().HasData(
            //     new Transaction
            //     {
            //         Amount = 3.00,
            //         Date = DateTime.Now,
            //         Description = "McDonald",
            //         TransactionId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
            //         AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
            //     },
            //     new Transaction
            //     {
            //         Amount = 5.00,
            //         Date = DateTime.Now,
            //         Description = "Wendy",
            //         TransactionId = new Guid("642ca94b-e714-4e60-b3ce-feab46a461b0"),
            //         AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
            //     }
            // );

            /*modelBuilder.Entity<User>().OwnsMany(user => user.Accounts).HasData(
                new Account
                {
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
                    BalanceRemaining = 4.00
                },
                new Account
                {
                    AccountId = new Guid("d5e17d64-6f1a-4ce0-834d-2fd367e273ca"),
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
                    BalanceRemaining = 10.00
                }
            );

            
            

            

            modelBuilder.Entity<Transaction>()
            .HasOne(transaction => transaction.Account)
            .WithMany(account => account.Transactions)
            .HasForeignKey(Transaction => Transaction.TransactionId)
            .HasData(
                
            );*/
            /*modelBuilder.Entity<Account>().OwnsMany(account => account.Transactions).HasData(
                new Transaction
                {
                    Amount = 3.00,
                    Date = DateTime.Now,
                    Description = "McDonald",
                    TransactionId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
                },
                new Transaction
                {
                    Amount = 5.00,
                    Date = DateTime.Now,
                    Description = "Wendy",
                    TransactionId = new Guid("642ca94b-e714-4e60-b3ce-feab46a461b0"),
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
                }
            );*/
        }
    }
}