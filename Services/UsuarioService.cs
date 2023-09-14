using AutoMapper;
using ExtensiApp.Data.Dtos;
using ExtensiApp.Models;
using ExtensiApp.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ExtensiApp.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;

        public UsuarioService(IMapper mapper, SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }
        public async Task CadastrarUsuario(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);
            var user = await _userManager.CreateAsync(usuario, dto.Password);

            if (!user.Succeeded)
                throw new Exception("Falha ao cadastrar usuário");
        }

        public async Task Login(LoginUsuarioDto dto)
        {
          var resultado = await _signInManager
                .PasswordSignInAsync(dto.UserName, dto.Password, false,false);

            if (!resultado.Succeeded)
            {
                throw new Exception("Usuário não autenticado!");
            }


        }
    }
}
