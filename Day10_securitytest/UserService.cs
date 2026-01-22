using Serilog;
using System.Collections.Generic;

namespace SecureApp
{
    public class UserService
    {
        private readonly List<User> users = new();
        private readonly ILogger logger;

        public UserService()
        {
            logger = new LoggerConfiguration()
                .WriteTo.File("app.log")
                .CreateLogger();
        }

        public void Register(string username, string password)
        {
            try
            {
                users.Add(new User(username, password));
                logger.Information("User registered: " + username);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Registration failed");
                throw;
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                var user = users.Find(u => u.Username == username);
                if (user == null) return false;
                bool result = user.Authenticate(password);
                logger.Information("Login attempt for: " + username);
                return result;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Login failed");
                throw;
            }
        }
    }
}
