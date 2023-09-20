using ExtensiApp.Models;

namespace ExtensiApp.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(Usuario usuario);
    }
}