using GraphQL.Types;
using MovieReviews.Models;

namespace MovieReviews.GraphQL.Types
{
    public sealed class UserObject : ObjectGraphType<User>
    {
        public UserObject()
        {
            Name = nameof(User);
            Description = "A user in the database";

            Field(m => m.UserId).Description("Identifier of the user");
            Field(m => m.LastName).Description("Last name of the user");
            Field(
                name: "Accounts",
                description: "Accounts of the user",
                type: typeof(ListGraphType<AccountObject>),
                resolve: m => m.Source.Accounts);
        }
    }
}