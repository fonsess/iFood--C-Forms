namespace api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public char Genero { get; set; }
        public string Nascimento { get; set; }
        public string Role { get; set; }
    }
}
