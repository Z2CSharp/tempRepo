using System;
using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;
using System.Collections.Generic;

namespace MovieReviews.Database
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Transaction> Transaction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>(entity =>
            // {
            //     entity.HasKey(e => e.UserId);
            //     entity.Property(e => e.LastName).IsRequired();
            // });
            // modelBuilder.Entity<Account>(entity => 
            // {
            //     entity.HasKey(e => e.AccountId);
            //     entity.Property(e => e.BalanceRemaining).IsRequired();
            //     entity.HasOne(d => d.User).WithMany(u => u.Accounts);
            // });
            // modelBuilder.Entity<Transaction>(entity =>
            // {
            //     entity.HasKey(e => e.TransactionId);
            //     entity.Property(e => e.Amount).IsRequired();
            //     entity.HasOne(t => t.Account).WithMany(a => a.Transactions);
            // });

            


            //modelBuilder.Entity<User>().HasKey(u => u.UserId);
            //modelBuilder.Entity<Account>().HasKey(a => a.AccountId);
            //modelBuilder.Entity<Transaction>().HasKey(t => t.TransactionId);

            modelBuilder.Entity<User>().OwnsMany(u => u.Accounts).HasData(
                new Account
                {
                    AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
                    BalanceRemaining = 4.00
                    // Transactions = new System.Collections.Generic.List<Transaction>{
                    //     new Transaction(new Guid("642ca94b-e714-4e60-b3ce-feab46a461b0"), /*new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),*/ 5.00, "Wendy", DateTime.Now)
                    // }
                },
                new Account
                {
                    AccountId = new Guid("d5e17d64-6f1a-4ce0-834d-2fd367e273ca"),
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
                    BalanceRemaining = 10.00,
                    // Transactions = new System.Collections.Generic.List<Transaction>{
                    //     new Transaction(new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"), /*new Guid("d5e17d64-6f1a-4ce0-834d-2fd367e273ca"),*/ 3.00, "McDonald", DateTime.Now)
                    // }
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User{
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "555-555-5555",
                    UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa")
                }
            );

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

            // // modelBuilder.Entity<User>().HasData(
            // //     new User
            // //     {
            // //         FirstName = "John",
            // //         LastName = "Doe",
            // //         Phone = "555-555-5555",
            // //         UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa")
            // //     }
            // // );

            // // modelBuilder.Entity<Account>().HasData(
            // //     new Account
            // //     {
            // //         AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
            // //         UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
            // //         BalanceRemaining = 4.00
            // //     },
            // //     new Account
            // //     {
            // //         AccountId = new Guid("d5e17d64-6f1a-4ce0-834d-2fd367e273ca"),
            // //         UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
            // //         BalanceRemaining = 10.00
            // //     }
            // // );

            // // modelBuilder.Entity<Transaction>().HasData(
            // //     new Transaction
            // //     {
            // //         Amount = 3.00,
            // //         Date = DateTime.Now,
            // //         Description = "McDonald",
            // //         TransactionId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
            // //         AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
            // //     },
            // //     new Transaction
            // //     {
            // //         Amount = 5.00,
            // //         Date = DateTime.Now,
            // //         Description = "Wendy",
            // //         TransactionId = new Guid("642ca94b-e714-4e60-b3ce-feab46a461b0"),
            // //         AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
            // //     }
            // // );

            // modelBuilder.Entity<User>().HasMany<Account>().WithOne(a => a.User);
            // modelBuilder.Entity<Account>().HasMany<Transaction>().WithOne(t => t.Account);
            // modelBuilder.Entity<User>().OwnsMany(user => user.Accounts).HasData(
            //     new Account
            //     {
            //         AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
            //         UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
            //         BalanceRemaining = 4.00,
            //         // Transactions = new System.Collections.Generic.List<Transaction>{
            //         //     new Transaction(new Guid("642ca94b-e714-4e60-b3ce-feab46a461b0"), /*new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),*/ 5.00, "Wendy", DateTime.Now)
            //         // }
            //     },
            //     new Account
            //     {
            //         AccountId = new Guid("d5e17d64-6f1a-4ce0-834d-2fd367e273ca"),
            //         UserId = new Guid("64c80451-5dae-421a-8357-0480894afafa"),
            //         BalanceRemaining = 10.00,
            //         // Transactions = new System.Collections.Generic.List<Transaction>{
            //         //     new Transaction(new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"), /*new Guid("d5e17d64-6f1a-4ce0-834d-2fd367e273ca"),*/ 3.00, "McDonald", DateTime.Now)
            //         // }
            //     }
            // );

            // modelBuilder.Entity<Account>().OwnsMany(x => x.Transactions).HasData(
            // modelBuilder.Entity<Transaction>().HasData(
            // new Transaction
            // {
            //     Amount = 3.00,
            //     Date = DateTime.Now,
            //     Description = "McDonald",
            //     TransactionId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477"),
            //     AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
            // },
            // new Transaction
            // {
            //     Amount = 5.00,
            //     Date = DateTime.Now,
            //     Description = "Wendy",
            //     TransactionId = new Guid("642ca94b-e714-4e60-b3ce-feab46a461b0"),
            //     AccountId = new Guid("9f0b3b83-1e0a-4a77-9700-8f0751d11477")
            // }
            // )
            // );
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