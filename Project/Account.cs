using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Account
    {
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        
        public void Import()
        {}

        public bool Export(string login, string pass)
        {
            return true;
        }
    }
}
