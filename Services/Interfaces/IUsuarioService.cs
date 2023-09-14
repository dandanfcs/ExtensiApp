using ExtensiApp.Data.Dtos;

namespace ExtensiApp.Services
{
    public interface IUsuarioService
    {
        Task CadastrarUsuario(CreateUsuarioDto dto);
        Task Login(LoginUsuarioDto dto);
    }
}
