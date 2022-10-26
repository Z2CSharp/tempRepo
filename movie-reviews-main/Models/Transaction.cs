using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviews.Models
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        // [ForeignKey("Account")]
        // public Guid AccountId { get; set; }
        // public Account Account { get; set; }
        public double Amount {get; set; }
        public string Description {get; set; }
        public DateTime Date {get; set; }

        // public Transaction(Guid transactionId, Guid accountId, double amount, string description, DateTime date)
        // {
        //     this.TransactionId = transactionId;
        //     this.AccountId = accountId;
        //     this.Amount = amount;
        //     this.Description = description;
        //     this.Date = date;
        // }
        public Transaction()
        {

        }
    }
}