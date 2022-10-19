using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;

namespace MovieReviews.Database
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public Task<User> GetUserByIdAsync(Guid userId)
        {
            return _context.User.Where(m => m.UserId == userId).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<User> AddAccountToUserAsync(Guid userId, Account account)
        {
            var user = await _context.User.Where(m => m.UserId == userId).FirstOrDefaultAsync();
            user.AddAccount(account);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}