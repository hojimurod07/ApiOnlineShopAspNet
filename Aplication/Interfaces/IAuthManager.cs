using Domain.Entities;

namespace Aplication.Interfaces
{
    public  interface IAuthManager
    {
        string GeneratedToken(User user);
    }
}
