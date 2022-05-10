using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class BLLAccountManagement
    {
        Account demo = new Account();
        private static BLLAccountManagement _instance;
        public static BLLAccountManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLAccountManagement();
                }
                return _instance;
            }
            private set
            {

            }
        }
        public dynamic GetAllAccount()
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            var account = (qLSPEntities.Accounts.Select(p => new { p.PersonID, p.Account1, p.Password, p.Person})).ToList();
            return account;
        }
        public void DelAccount(string ID)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            Account temp = qLSPEntities.Accounts.Find(ID);
            qLSPEntities.Accounts.Remove(temp);
            qLSPEntities.SaveChanges();
        }
        public bool Check(string ID)
        {
            bool Add = false;
            foreach (Account ac in GetAllAccount())
            {
                if (ac.PersonID == ID)
                {
                    Add = true;
                    break;
                }
            }
            return Add;

        }
        public void Execute(Account ac)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            if (Check(ac.PersonID) == true)
            {   
                Account temp = qLSPEntities.Accounts.Find(ac.PersonID);
                temp.PersonID = ac.PersonID;
                temp.Account1 = ac.Account1;
                temp.Password = ac.Password;
                temp.Person = ac.Person;
                qLSPEntities.SaveChanges();
            }
            else
            {
                qLSPEntities.Accounts.Add(ac);
                qLSPEntities.SaveChanges();

            }
        }
        public dynamic SearchAccount(string value)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            List<Account> data = new List<Account>();
            foreach(Account ac in GetAllAccount())
            {
                if (ac.PersonID.Contains(value) == true )
                {
                    data.Add(ac);
                }
            }
            var account = data.Select(p => new{ p.PersonID, p.Account1, p.Password, p.Person }) ; 
            return account;

        }
    }
 }

