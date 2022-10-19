using System;
using GraphQL;
using GraphQL.Types;
using MovieReviews.Database;
using MovieReviews.GraphQL.Types;
using MovieReviews.Models;

namespace MovieReviews.GraphQL
{
    public class MutationObject : ObjectGraphType<object>
    {
        public MutationObject(IMovieRepository repository)
        {
            Name = "Mutations";
            Description = "The base mutation for all the entities in our object graph.";

            FieldAsync<MovieObject, Movie>(
                "addReview",
                "Add review to a movie.",
                new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>>
                    {
                        Name = "id",
                        Description = "The unique GUID of the movie."
                    },
                    new QueryArgument<NonNullGraphType<ReviewInputObject>>
                    {
                        Name = "review",
                        Description = "Review for the movie."
                    }),
                context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    var review = context.GetArgument<Review>("review");
                    return repository.AddReviewToMovieAsync(id, review);
                });
        }

        public MutationObject(IUserRepository repository)
        {
            Name = "Mutations";
            Description = "The base mutation for all the entities in our object graph.";

            FieldAsync<UserObject, User>(
                "addAccount",
                "Add account to a user.",
                new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>>
                    {
                        Name = "userid",
                        Description = "The unique GUID of the User."
                    },
                    /*new QueryArgument<NonNullGraphType<ReviewInputObject>>
                    {
                        Name = "account",
                        Description = "Account for the user."
                    }*/
                    new QueryArgument<NonNullGraphType<AccountInputObject>>
                    {
                        Name = "account",
                        Description = "Account for the user."
                    }
                ),
            context =>
            {
                var userId = context.GetArgument<Guid>("userid");
                var account = context.GetArgument<Account>("account");
                return repository.AddAccountToUserAsync(userId, account);
            });
        }
    }
}