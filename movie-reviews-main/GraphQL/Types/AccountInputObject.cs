using GraphQL.Types;
using MovieReviews.Models;

namespace MovieReviews.GraphQL.Types
{
    public sealed class AccountInputObject : InputObjectGraphType<Account>
    {
        public AccountInputObject()
        {
            Name = "AccountInput";
            Description = "An account attached to a user";

            Field(r => r.UserId).Description("User Id of the account holder");
            Field(r => r.BalanceRemaining).Description("Remaining balance within the account");
            Field(r => r.AccountId).Description("Id for the account");
            /*Field(
                name: "Transactions",
                description: "Transactions of this account",
                type: typeof(ListGraphType<TransactionObject>),
                resolve: m => m.Source.Transactions);*/
        }
    }
}