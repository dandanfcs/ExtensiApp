using System.ComponentModel.DataAnnotations;

namespace ExtensiApp.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime DataNascimento { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
