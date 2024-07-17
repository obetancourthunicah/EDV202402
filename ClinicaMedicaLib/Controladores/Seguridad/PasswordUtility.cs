using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClinicaMedicaLib.Controladores.Seguridad
{
    internal class PasswordUtility
    {
        private static int iterations = 10000;
        private static int keySize = 64;
        private static HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

        public static string hashPassword( string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                iterations,
                hashAlgorithm,
                keySize
             );
            return Convert.ToHexString(hash);
        }

        public static bool comparePassword(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}
