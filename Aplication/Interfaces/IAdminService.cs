using Domain.Entities;

namespace Aplication.Interfaces
{
    public  interface IAdminService
    {
        Task ChangeUserRoleAsync(int id);
        Task DeleteUserAsync(int id);
        Task<List<User>> GetAllAdminAsync();
    }
}
