using net03_API_DB.DataAccess;
using net03_API_DB.Models;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace net03_API_DB.Functions
{
    public class SignUp
    {
        private static readonly List<Account> _accountList = new();
        private readonly Context _db;
        public Account SignUpNewAccount(string username, string password)
        {
            var account = CreateAccount(username, password);
            _applicationDbContext.SaveAccount(account);
            return account;
        }

        private Account CreateAccount(string username, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            var account = new Account
            {
                UserName = username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = "User"
            };
            return account;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }


    }
}
