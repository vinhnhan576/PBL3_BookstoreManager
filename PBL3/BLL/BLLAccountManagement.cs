using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class BLLAccountManagement
    {
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
            var account = (qLSPEntities.Accounts.Select(p => new { p.PersonID, p.Account1, p.Password, p.Person.PersonName,p.Person.Address})).ToList();
            return account;
        }
        public void DelAccount(List<string> ID)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            foreach (string i in ID)
            {
                Account ac = qLSPEntities.Accounts.Find(i);
                qLSPEntities.Accounts.Remove(ac);
                qLSPEntities.SaveChanges();
            }
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
        public void AddNewAccount(Account ac)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            qLSPEntities.Accounts.Add(ac);
            qLSPEntities.SaveChanges();
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
            foreach (Account ac in qLSPEntities.Accounts.Select(p => p).ToList())
            {
                if (ac.PersonID.Contains(value) == true )
                {
                    data.Add(ac);
                }
            }
            var account = data.Select(p => new{ p.PersonID, p.Account1, p.Password, p.Person }) ; 
            return account.ToList();
        }
        public dynamic SortAcount(string sortCategory, bool ascending)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            List<Account> data = new List<Account>();
            if (sortCategory == "ID")
            {
                if (ascending)
                    data = qLSPEntities.Accounts.OrderBy(p => p.PersonID).ToList();
                else
                    data = qLSPEntities.Accounts.OrderByDescending(p => p.PersonID).ToList();
            }
            if (sortCategory == "Name")
            {
                if (ascending)
                    data = qLSPEntities.Accounts.OrderBy(p => p.Person.PersonName).ToList();
                else
                    data = qLSPEntities.Accounts.OrderByDescending(p => p.Person.PersonName).ToList();
            }
            return data;
        }
        public Account GetAccountByPersonID(string ID)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            Account ac = qLSPEntities.Accounts.Find(ID);
            return ac;
        }
    }
 }

