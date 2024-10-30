using System.ComponentModel.DataAnnotations;

namespace api.ViewModel
{
    public class UserLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class UserCadastroViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public char Genero { get; set; }
        [Required]
        public string Nascimento { get; set; }
    }
    public class UserUpdateViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public char Genero { get; set; }
        [Required]
        public string Nascimento { get; set; }
    }
}
