using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsApp.DB;

namespace WinFormsApp.Controllers
{
    public class OperationController
    {
        readonly DataBase db;
        public OperationController(DataBase db)
        {
            this.db = db;
        }
        public bool TransferMoney(User fromUser, string toUser, int money)
        {
            if (money < 0) return false;
            if (fromUser.Money < money) return false;

            var finded = (from u in db.Users
                          where toUser == u.Login
                          select u).FirstOrDefault();

            if (finded is not null)
            {
                db.Operations.Add(new Operation()
                    { Sender = fromUser, Payee = finded.Login, Sum = money }
                );
                fromUser.Money -= money;
                finded.Money += money;
                db.Users.Update(fromUser);
                db.Users.Update(finded);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool CheatMoney(string toUser, int money)
        {
            var finded = (from u in db.Users
                          where toUser == u.Login
                          select u).FirstOrDefault();

            if (finded is not null)
            {
                finded.Money += money;
                db.Users.Update(finded);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public List<(string name, int money)> GetOutputOperations(User user)
        {
            var finded = (from o in db.Operations
                          where user == o.Sender
                          select new Tuple<string, int>(o.Payee, o.Sum).ToValueTuple())
                          .ToList();
            return finded;
        }
        public List<(string name, int money)> GetInputOperations(string user)
        {
            var finded = (from o in db.Operations
                          where user == o.Payee
                          select new Tuple<string, int>(o.Sender.Login, o.Sum).ToValueTuple())
                          .ToList();
            return finded;
        }
    }
}
