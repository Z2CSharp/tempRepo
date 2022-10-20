using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviews.Models
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId {get; set; }
        [ForeignKey("Account")]
        public Guid AccountId { get; set; }
        public double Amount {get; set; }
        public string Description {get; set; }
        public DateTime Date {get; set; }

    }
}