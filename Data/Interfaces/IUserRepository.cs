using Domain.Entities;

namespace Data.Interfaces
{
    public  interface IUserRepository:IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
    }
}
