using System.Linq;
using System.Security.Cryptography;

namespace net03_API_DB.Functions
{
    public class LogIn
    {
        public bool Login(string username, string password, out string role)
        {
            var account = _applicationDbContext.GetAccount(username);
            role = account.Role;
            if(VerifyPasswordHash(password, account.PasswordHash, account.PasswordSalt))
                return true;
            return false;
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }
}
