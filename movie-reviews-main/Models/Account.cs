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
        public List<Transaction> Transactions { get; set;}
        public double BalanceRemaining { get; set;}

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}