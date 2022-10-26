using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviews.Models
{
    public class Account
    {
        [Key]
        public Guid AccountId { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User{ get; set; }
        public double BalanceRemaining { get; set;}

        // public Account(Guid accountId, Guid userId, double balanceRemaining, List<Transaction> transactions)
        // {
        //     AccountId = accountId;
        //     UserId = userId;
        //     BalanceRemaining = balanceRemaining;
        //     Transactions = transactions;
        // }
        // public Account(Guid accountId, Guid userId, double balanceRemaining)
        // {
        //     AccountId = accountId;
        //     UserId = userId;
        //     BalanceRemaining = balanceRemaining;
        // }

        public Account()
        {

        }

        // public void AddTransaction(Transaction transaction)
        // {
        //     Transactions.Add(transaction);
        // }
    }
}