using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoginServiceApp
{
    public class LoginService
    {
        private Dictionary<string, string> userCredentials = new Dictionary<string, string>();

        public LoginService()
        {

            userCredentials.Add("user1", HashPassword("password1"));
            userCredentials.Add("user2", HashPassword("password2"));

        }

        public bool CheckLogin(string username, string password)
        {
            if (userCredentials.ContainsKey(username))
            {
                string storedHashedPassword = userCredentials[username];
                string inputHashedPassword = HashPassword(password);
                return storedHashedPassword == inputHashedPassword;
            }

            return false;
        }

        private string HashPassword(string password)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                var btyesArrOfPwd = Encoding.UTF8.GetBytes(password);
                var btyesArrOfPwdHashed = sha1.ComputeHash(btyesArrOfPwd);
                return Convert.ToBase64String(btyesArrOfPwdHashed);


            }
        }


    }

}
