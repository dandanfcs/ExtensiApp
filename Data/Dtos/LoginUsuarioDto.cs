using System.ComponentModel.DataAnnotations;

namespace ExtensiApp.Data.Dtos
{
    public class LoginUsuarioDto
    {
        [Required]  
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
