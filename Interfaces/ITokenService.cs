using myWebApi.Models;

namespace myWebApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}