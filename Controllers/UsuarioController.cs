using AutoMapper;
using ExtensiApp.Data.Dtos;
using ExtensiApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExtensiApp.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        { 
            _usuarioService = usuarioService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDto dto)
        {
            await _usuarioService.CadastrarUsuario(dto);
            return Ok("Usuário cadastrado com sucesso!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            await _usuarioService.Login(dto);
            return Ok("Usuário autenticado com sucesso!");
        }
    }
}
