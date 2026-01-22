using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecureApp;

namespace SecureAppTests
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void Register_User_Success()
        {
            UserService service = new UserService();
            service.Register("sai", "password123");
            bool result = service.Login("sai", "password123");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_Fails_With_Wrong_Password()
        {
            UserService service = new UserService();
            service.Register("ram", "secret");
            bool result = service.Login("ram", "wrong");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Password_Is_Hashed()
        {
            User user = new User("john", "mypassword");
            Assert.AreNotEqual("mypassword", user.HashedPassword);
        }

        [TestMethod]
        public void Encryption_Decryption_Works()
        {
            EncryptionService enc = new EncryptionService();
            var encrypted = enc.Encrypt("SensitiveData");
            var decrypted = enc.Decrypt(encrypted);
            Assert.AreEqual("SensitiveData", decrypted);
        }

        [TestMethod]
        public void Invalid_Login_Returns_False()
        {
            UserService service = new UserService();
            bool result = service.Login("ghost", "none");
            Assert.IsFalse(result);
        }
    }
}
