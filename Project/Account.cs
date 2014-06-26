using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Account
    {
        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int CurrCourse { get; private set; }
        
        public void SetLogin(string login)
        {
            Login = login;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
    }
}
