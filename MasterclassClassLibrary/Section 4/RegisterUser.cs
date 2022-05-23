using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_4
{
    public class RegisterUser
    {
        private readonly string _username;
        private readonly string _password;

        public RegisterUser(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string CheckLogin(string username, string password)
        {
            string loginCheck;

            if (_username == username)
            {
                if (_password == password)
                {
                    loginCheck = "User is successfully logged in";
                }
                else
                {
                    loginCheck = "Incorrect password";
                }
            }
            else
            {
                loginCheck = "Incorrect username";
            }

            return loginCheck;
        }
    }
}
