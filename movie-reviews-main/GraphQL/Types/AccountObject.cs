﻿using GraphQL.Types;
using MovieReviews.Models;

namespace MovieReviews.GraphQL.Types
{
    public sealed class AccountObject : ObjectGraphType<Account>
    {
        public AccountObject()
        {
            Name = nameof(Account);
            Description = "An account of the user";

            Field(r => r.AccountId).Description("Id of the account");
            Field(r => r.BalanceRemaining).Description("Balance remaining on this account");
            Field(r => r.UserId).Description("UserId of the account holder");
            Field(r => r.Transactions).Description("Transactions attached to this account");
        }
    }
}