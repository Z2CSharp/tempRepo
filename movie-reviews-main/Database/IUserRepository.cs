using System;
using System.Threading.Tasks;
using MovieReviews.Models;

namespace MovieReviews.Database
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(Guid userId);
        Task<User> AddAccountToUserAsync(Guid userId, Account account);
        Task<User> RemoveAccountFromUserAsync(Guid userId, Guid accountId);
    }
}