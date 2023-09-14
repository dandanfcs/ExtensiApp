using AutoMapper;
using ExtensiApp.Data.Dtos;
using ExtensiApp.Models;

namespace ExtensiApp.Profiles
{
    public class UsuarioProfile : Profile
    {

        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>(); 
        }
    }
}

