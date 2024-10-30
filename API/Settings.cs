using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;

namespace api
{
    public class Settings
    {
        public static string Secret { get; set; } = "GUIufVJOcfkjgCCCcgjkCgjkcKJGcghXGHvlKHVfyCVHhFvjCVjhXNGxkFHXKgxKG";

        public static string GenerateHash(string password)
        {
            byte[] salt = Encoding.UTF8.GetBytes("315284976481245");

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 32));

            return hashed;
        }
    }
}
