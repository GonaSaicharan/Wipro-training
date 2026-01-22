using System.Security.Cryptography;
using System.Text;

namespace SecureApp
{
    public class EncryptionService
    {
        private readonly byte[] key = Encoding.UTF8.GetBytes("1234567890123456");
        private readonly byte[] iv = Encoding.UTF8.GetBytes("6543210987654321");

        public byte[] Encrypt(string data)
        {
            using Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;

            using var encryptor = aes.CreateEncryptor();
            byte[] input = Encoding.UTF8.GetBytes(data);
            return encryptor.TransformFinalBlock(input, 0, input.Length);
        }

        public string Decrypt(byte[] encryptedData)
        {
            using Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;

            using var decryptor = aes.CreateDecryptor();
            byte[] decrypted = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
