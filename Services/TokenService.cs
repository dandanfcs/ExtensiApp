using ExtensiApp.Models;
using ExtensiApp.Services.Interfaces;
using System.Security.Claims;

namespace ExtensiApp.Services
{
    public class TokenService : ITokenService
    {
        public TokenService() { }
        public void GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", usuario.UserName),
                new Claim("id", usuario.Id)
            };


        }

    }
}
