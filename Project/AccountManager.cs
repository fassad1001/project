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
            using (var db = new DataBaseUser())
            {
                db.Accounts.Add(acc);
                db.SaveChanges();
            }
            
        }
        static public void RemAcc(string login)
        {
            using (var db = new DataBaseUser())
            {
                db.Accounts.Remove(db.Accounts.Single(a => a.Login == login));
            }
        }
        static public void UpdAcc(string oldLogin, string oldPassword, string newLogin, string newPassword)
        {
            using (var db = new DataBaseUser())
            {
                var acc = db.Accounts.Single(a => a.Login == oldLogin && a.Password == oldPassword);
                acc.SetLogin(newLogin);
                acc.SetPassword(newPassword);
                db.SaveChanges();
            }
        }
        static public string Register(string login, string password)
        {
            using (var db = new DataBaseUser())
            {
                if (db.Accounts.Any(a => a.Login == login))
                {
                    return "Use another login! =(";
                }
                NewAcc(login, password);
                return "Success, you have successfully signed up! =)";
            }
        }
        static public string Login(string login, string password)
        {
            using (var db = new DataBaseUser())
            {
                if (db.Accounts.Any(a => a.Login == login && a.Password == password))
                {
                    return "You are sucesfully Logged! =)";
                }
                else
                {
                    return "Login or Password is incorrect!";
                }
            }
        }
    }
}
