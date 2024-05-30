

using Domain.Entities;
using Domain.Enums;
using System.Data.SqlTypes;

namespace Aplication.DTOs.UserDtos
{
    public class AddUserDto
    {
        public string FullName {  get; set; }  = string.Empty;  
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public List<Busket> buskets { get; set; } = new List<Busket>();
        public static implicit operator User(AddUserDto dto)
        {
            return new User()
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Password = dto.Password,
                Gender = dto.Gender,
                Role = dto.Role,
                buskets = dto.buskets,
            };
        }
    }
}
