
using Data.DbContexts.AppDbContext;
using Data.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Reositories
{
    public class UserRepository(AppDbContext dbContext) : Repository<User>(dbContext), IUserRepository
    {
        public async Task<User?> GetByEmailAsync(string email)
        
            => await _dbContext.Users.FirstOrDefaultAsync(mail => mail.Email == email);
        
    }
}
