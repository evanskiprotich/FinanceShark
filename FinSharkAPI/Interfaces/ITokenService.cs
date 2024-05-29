using FinSharkAPI.Models;

namespace FinSharkAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
