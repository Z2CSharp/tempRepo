using System;
using GraphQL;
using GraphQL.Types;
using MovieReviews.Database;
using MovieReviews.GraphQL.Types;
using MovieReviews.Models;

namespace MovieReviews.GraphQL
{
    public class QueryObject : ObjectGraphType<object>
    {
        public QueryObject(IMovieRepository repository)
        {
            Name = "Queries";
            Description = "The base query for all the entities in our object graph.";

            FieldAsync<MovieObject, Movie>(
                "movie",
                "Gets a movie by its unique identifier.",
                new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>>
                    {
                        Name = "id",
                        Description = "The unique GUID of the movie."
                    }),
                context => repository.GetMovieByIdAsync(context.GetArgument("id", Guid.Empty)));
        }

        public QueryObject(IUserRepository repository)
        {
            Name = "Queries";
            Description = "The base query for all the entities in our object graph.";

            FieldAsync<UserObject, User>(
                "user",
                "Gets a user by its unique identifier.",
                new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>>
                    {
                        Name = "userId",
                        Description = "The unique GUID of the user."
                    }),
                    context => repository.GetUserByIdAsync(context.GetArgument("userId", Guid.Empty)));
        }
    }
}