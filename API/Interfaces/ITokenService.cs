using API.Entites;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CtreateToken(AppUser user);
    }
}