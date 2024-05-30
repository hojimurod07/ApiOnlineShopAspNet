using Aplication.DTOs.UserDtos;

namespace Aplication.Interfaces
{
    public  interface IUserService
    {
   
        Task UpdateAsync(int id ,UpdateUserDto updateUserDto);
        Task DeleteAsync(int id);
        Task<List<UserDto>> GetAllAsync();  
        Task<UserDto> GetByIdAsync(int id);

    }
}
