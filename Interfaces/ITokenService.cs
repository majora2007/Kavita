using Kavita.Entities;

namespace Kavita.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}