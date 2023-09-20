using ExtensiApp.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ExtensiApp.Services
{
    public class TokenService 
    {
        public TokenService() { }
        public string GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", usuario.UserName),
                new Claim("id", usuario.Id)
            };

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("394idb78te8dfgdgadfgdasgfdgfdafdgfdg732"));

            var signingCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddMinutes(30),
                claims: claims,
                signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
