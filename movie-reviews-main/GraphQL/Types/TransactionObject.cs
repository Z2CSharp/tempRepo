using GraphQL.Types;
using MovieReviews.Models;

namespace MovieReviews.GraphQL.Types
{
    public sealed class TransactionObject : ObjectGraphType<Transaction>
    {
        public TransactionObject()
        {
            Name = nameof(Transaction);
            Description = "A transaction within an account";
            
            Field(r => r.AccountId).Description("Account Id the transaction was billed to");
            Field(r => r.Amount).Description("Amount in USD ($) the transaction was valued");
            Field(r => r.Date).Description("Date the transaction took place");
            Field(r => r.Description).Description("Description of the transaction");
            Field(r => r.TransactionId).Description("The Guid of the transaction");
        }
    }
}