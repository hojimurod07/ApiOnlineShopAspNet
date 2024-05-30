
using Domain.Entities;
using Domain.Enums;

namespace Aplication.DTOs.UserDtos
{
    public class UserDto
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public List<Busket> buskets { get; set; } = new List<Busket>();
        public static implicit operator UserDto(User user)
        {
            return new UserDto()
            {
                FullName = user.FullName,
                Email = user.Email,
                Password = user.Password,
                Gender = user.Gender,
                Role = user.Role,
                buskets = user.buskets

            };
        }
    }
}
