using System;
using GraphQL.Types;

namespace MovieReviews.GraphQL
{
    public class UserSchema : Schema
    {
        // ReSharper disable once SuggestBaseTypeForParameter
        public UserSchema(QueryObject query, MutationObject mutation, IServiceProvider sp) : base(sp)
        {
            Query = query;
            Mutation = mutation;
        }
    }
}