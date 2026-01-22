using System.Security.Cryptography;
using System.Text;

namespace SecureApp
{
    public class User
    {
        public string Username { get; set; }
        public string HashedPassword { get; set; }

        public User(string username, string password)
        {
            Username = username;
            HashedPassword = HashPassword(password);
        }

        public bool Authenticate(string password)
        {
            string hash = HashPassword(password);
            return hash == HashedPassword;
        }

        private string HashPassword(string password)
        {
            using SHA256 sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
