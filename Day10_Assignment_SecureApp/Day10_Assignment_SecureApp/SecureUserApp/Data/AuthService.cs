using SecureUserApp.Data;
using SecureUserApp.Models;
using System;
using System.Linq;

namespace SecureUserApp.Services
{
    public class AuthService
    {
        public bool Register(string username, string password, string secret)
        {
            try
            {
                if (UserStore.Users.Any(u => u.Username == username))
                    return false;

                var user = new User
                {
                    Username = username,
                    HashedPassword = CryptoService.HashPassword(password),
                    EncryptedSecret = CryptoService.Encrypt(secret)
                };

                UserStore.Users.Add(user);
                Logger.Info($"User registered: {username}");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                var user = UserStore.Users.FirstOrDefault(u => u.Username == username);
                if (user == null) return false;

                bool valid = CryptoService.VerifyPassword(password, user.HashedPassword);
                Logger.Info(valid ? $"Login success: {username}" : $"Login failed: {username}");
                return valid;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
        }

        public string GetSecret(string username)
        {
            var user = UserStore.Users.FirstOrDefault(u => u.Username == username);
            return CryptoService.Decrypt(user.EncryptedSecret);
        }
    }
}