using System;
using System.Collections.Generic;

namespace MovieReviews.Models
{
    public class Account
    {
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public List<Transaction> Transactions { get; set;}
        public double BalanceRemaining { get; set;}

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}