
using Domain.Enums;
using Microsoft.VisualBasic;

namespace Domain.Entities
{
    public  class User:BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password {  get; set; } = string.Empty;
        public string Adress {  get; set; } = string.Empty;
        public Gender Gender {  get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public List<Busket> buskets { get; set; } = new List<Busket>();
    }
}
