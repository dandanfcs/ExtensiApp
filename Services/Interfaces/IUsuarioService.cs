using ExtensiApp.Data.Dtos;

namespace ExtensiApp.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task CadastrarUsuario(CreateUsuarioDto dto);
        Task<string> Login(LoginUsuarioDto dto);
    }
}
