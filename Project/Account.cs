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
        
        //public void import()
        //{}

        //public bool export(string login, string pass)
        //{
        //    return true;
        //}
    }
}
