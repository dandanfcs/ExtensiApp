using ExtensiApp.Models;

namespace ExtensiApp.Services.Interfaces
{
    public interface ITokenService
    {
        void GenerateToken(Usuario usuario);
    }
}