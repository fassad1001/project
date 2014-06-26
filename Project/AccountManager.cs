using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static public class AccountManager
    {
        static public Account CurrUser { get; set; }
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
            if (login.Length == 0 || password.Length == 0)
            {
                return "{________} <--ЛОГИН\n{________} <--ПАРОЛЬ\n\nОба поля должны быть заполнены!";
            }
            using (var db = new DataBaseUser())
            {
                if (db.Accounts.Any(a => a.Login == login))
                {
                    return "Попробуйте другой логин! =(";
                }
                NewAcc(login, password);
                return "Успех! Вы зарегистрировались! =)";
            }
        }
        static public string Login(string login, string password)
        {
            using (var db = new DataBaseUser())
            {
                if (db.Accounts.Any(a => a.Login == login && a.Password == password))
                {
                    CurrUser = db.Accounts.Single(a => a.Login == login && a.Password == password);
                    return "Вы успешно вошли в систему! =)";
                }
                else
                {
                    return "Логин или пароль неправильный!";
                }
            }
        }
        static public bool HasLogged(string login, string password)
        {
            using (var db = new DataBaseUser())
            {
                if (db.Accounts.Any(a => a.Login == login && a.Password == password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static public bool HasRegistered(string login, string password)
        {
            if (login.Length == 0 || password.Length == 0)
            {
                return false;
            }
            using (var db = new DataBaseUser())
            {
                if (db.Accounts.Any(a => a.Login == login))
                {
                    return false;
                }
                NewAcc(login, password);
                return true;
            }
        }
    }
}
