//You can see more at: 
// https://www.codeproject.com/Articles/769741/Csharp-AES-bits-Encryption-Library-with-Salt

using System.Security.Cryptography;
using System.IO;
using System.Text;
using System;
namespace Cosmetic.Encrytions
{
    public class Encrytion
    {
        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }

        public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }
        //password is key, input is password of user
        public string EncryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }
        //password is key, input is password of user
        public string DecryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
        public void EncryptFile()
        {
            string file = "C:\\SampleFile.DLL";
            string password = "abcd1234";

            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string fileEncrypted = "C:\\SampleFileEncrypted.DLL";

            File.WriteAllBytes(fileEncrypted, bytesEncrypted);
        }
        public void DecryptFile()
        {
            string fileEncrypted = "C:\\SampleFileEncrypted.DLL";
            string password = "abcd1234";

            byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string file = "C:\\SampleFile.DLL";
            File.WriteAllBytes(file, bytesDecrypted);
        }
        public string EncryptString(string text, string password)
        {
            byte[] baPwd = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            byte[] baPwdHash = SHA256Managed.Create().ComputeHash(baPwd);

            byte[] baText = Encoding.UTF8.GetBytes(text);

            byte[] baSalt = GetRandomBytes();
            byte[] baEncrypted = new byte[baSalt.Length + baText.Length];

            // Combine Salt + Text
            for (int i = 0; i < baSalt.Length; i++)
                baEncrypted[i] = baSalt[i];
            for (int i = 0; i < baText.Length; i++)
                baEncrypted[i + baSalt.Length] = baText[i];

            baEncrypted = AES_Encrypt(baEncrypted, baPwdHash);

            string result = Convert.ToBase64String(baEncrypted);
            return result;
        }
        public string DecryptString(string text, string password)
        {
            byte[] baPwd = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            byte[] baPwdHash = SHA256Managed.Create().ComputeHash(baPwd);

            byte[] baText = Convert.FromBase64String(text);

            byte[] baDecrypted = AES_Decrypt(baText, baPwdHash);

            // Remove salt
            int saltLength = GetSaltLength();
            byte[] baResult = new byte[baDecrypted.Length - saltLength];
            for (int i = 0; i < baResult.Length; i++)
                baResult[i] = baDecrypted[i + saltLength];

            string result = Encoding.UTF8.GetString(baResult);
            return result;
        }
        public static byte[] GetRandomBytes()
        {
            int saltLength = GetSaltLength();
            byte[] ba = new byte[saltLength];
            RNGCryptoServiceProvider.Create().GetBytes(ba);
            return ba;
        }

        public static int GetSaltLength()
        {
            return 8;
        }
        
    }
    public sealed class PasswordHasher
    {
        public byte Version => 1;
        public int Pbkdf2IterCount { get; } = 50000;
        public int Pbkdf2SubkeyLength { get; } = 256 / 8; // 256 bits
        public int SaltSize { get; } = 128 / 8; // 128 bits
        public HashAlgorithmName HashAlgorithmName { get; } = HashAlgorithmName.SHA256;

        public string HashPassword(string password)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            byte[] salt;
            byte[] bytes;
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, SaltSize, Pbkdf2IterCount, HashAlgorithmName))
            {
                salt = rfc2898DeriveBytes.Salt;
                bytes = rfc2898DeriveBytes.GetBytes(Pbkdf2SubkeyLength);
            }

            var inArray = new byte[1 + SaltSize + Pbkdf2SubkeyLength];
            inArray[0] = Version;
            Buffer.BlockCopy(salt, 0, inArray, 1, SaltSize);
            Buffer.BlockCopy(bytes, 0, inArray, 1 + SaltSize, Pbkdf2SubkeyLength);

            return Convert.ToBase64String(inArray);
        }

        public PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string password)
        {
            if (password == null)
                //throw new ArgumentNullException(nameof(password));
                return PasswordVerificationResult.ErrorNull;

            if (hashedPassword == null)
                return PasswordVerificationResult.Failed;

            byte[] numArray = Convert.FromBase64String(hashedPassword);
            if (numArray.Length < 1)
                return PasswordVerificationResult.Failed;

            byte version = numArray[0];
            if (version > Version)
                return PasswordVerificationResult.Failed;

            byte[] salt = new byte[SaltSize];
            Buffer.BlockCopy(numArray, 1, salt, 0, SaltSize);
            byte[] a = new byte[Pbkdf2SubkeyLength];
            Buffer.BlockCopy(numArray, 1 + SaltSize, a, 0, Pbkdf2SubkeyLength);
            byte[] bytes;
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, Pbkdf2IterCount, HashAlgorithmName))
            {
                bytes = rfc2898DeriveBytes.GetBytes(Pbkdf2SubkeyLength);
            }

            if (FixedTimeEquals(a, bytes))
                return PasswordVerificationResult.Success;

            return PasswordVerificationResult.Failed;
        }

        // In .NET Core 2.1, you can use CryptographicOperations.FixedTimeEquals
        // https://github.com/dotnet/corefx/blob/a10890f4ffe0fadf090c922578ba0e606ebdd16c/src/System.Security.Cryptography.Primitives/src/System/Security/Cryptography/CryptographicOperations.cs#L32
        //[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static bool FixedTimeEquals(byte[] left, byte[] right)
        {
            // NoOptimization because we want this method to be exactly as non-short-circuiting as written.
            // NoInlining because the NoOptimization would get lost if the method got inlined.
            if (left.Length != right.Length)
            {
                return false;
            }

            int length = left.Length;
            int accum = 0;

            for (int i = 0; i < length; i++)
            {
                accum |= left[i] - right[i];
            }

            return accum == 0;
        }
    }

    public enum PasswordVerificationResult
    {
        ErrorNull,
        Failed,
        Success,
        SuccessRehashNeeded,
    }
}