using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static public class AccountManager
    {
        static public void NewAcc(string login, string password)
        {
            Account acc = new Account(login, password);
            var db = new DataBaseUser();
            db.Accounts.Add(acc);
            db.SaveChanges();
            db.Dispose();
        }
        static public void RemAcc(string login)
        {

        }
        static public void UpdAcc(string oldLogin, string oldPassword, string newLogin, string newPassword)
        {

        }
    }
}
