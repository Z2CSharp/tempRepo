using System;
using System.Collections.Generic;

namespace MovieReviews.Models
{
    public class Transaction
    {
        public Guid TransactionId {get; set; }
        public Guid AccountId { get; set; }
        public double Amount {get; set; }
        public string Description {get; set; }
        public DateTime Date {get; set; }


    }
}