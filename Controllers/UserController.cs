using System;
using System.Linq;
using System.Collections.Generic;
using WinFormsApp.DB;

namespace WinFormsApp.Controllers
{
    public class UserController
    {
        readonly DataBase db;
        public UserController(DataBase db)
        {
            this.db = db;
        }
        public User ActiveUser { get; set; }
        public bool AuthUser(string login, string pass)
        {
            var result = (from u in db.Users
                            where login == u.Login &&
                            pass == u.Pass
                            select u).FirstOrDefault();
            if (result is not null)
            {
                ActiveUser = result;
                return true;
            }
            return false;
        }
        public bool RegisterUser(string login, string pass, string name, bool admin)
        {
            var finded = (from u in db.Users
                          where login == u.Login
                          select u).FirstOrDefault();
            if (finded is null)
            {
                db.Users.Add(new User() { Login = login, Pass = pass, Name = name, Admin = admin });
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
