using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

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

        public List<Account> GetAllAccount()
        {
            List<Account> accountList = new List<Account>();
            foreach(Account i in QLNS.Instance.Accounts.ToList())
                accountList.Add(i);
            return accountList;
        }

        public dynamic GetAllAccount_View()
        {
            List<Account> accountList = new List<Account>();
            foreach (Account i in QLNS.Instance.Accounts.Select(p => p).ToList())
                accountList.Add(i);
            var account = accountList.Select(p => new { p.PersonID, p.Person.PersonName, p.Person.Role, p.Username, p.Person.Address });
            return account.ToList();
        }

        public void DelAccount(List<string> ID)
        {
            QLNS qLSPEntities = new QLNS();
            foreach (string i in ID)
            {
                Account ac = qLSPEntities.Accounts.Find(i);
                qLSPEntities.People.Remove(ac.Person);
                qLSPEntities.Accounts.Remove(ac);
                qLSPEntities.SaveChanges();
            }
        }
        public bool Check(string ID)
        {
            QLNS qLSPEntities = new QLNS();
            bool Add = false;
            foreach (Account ac in qLSPEntities.Accounts.Select(p=>p).ToList())
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
            QLNS qLSPEntities = new QLNS();
            qLSPEntities.Accounts.Add(ac);
            qLSPEntities.SaveChanges();
        }
        public void Execute(Account ac)
        {
            QLNS qLSPEntities = new QLNS();
            if (Check(ac.PersonID) == true)
            {   
                Account temp = qLSPEntities.Accounts.Find(ac.PersonID);
                temp.PersonID = ac.PersonID;
                temp.Username = ac.Username;
                temp.Password = ac.Password;
                temp.Person.Address = ac.Person.Address;
                temp.Person.PersonName = ac.Person.PersonName;
                temp.Person.Gender = ac.Person.Gender;
                temp.Person.Role = ac.Person.Role;
                temp.Person.PhoneNumber = ac.Person.PhoneNumber;
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
            QLNS qLSPEntities = new QLNS();
            List<Account> data = new List<Account>();
            foreach (Account ac in qLSPEntities.Accounts.Select(p => p).ToList())
            {
                if (ac.Person.PersonName.Contains(value) == true)
                {
                    data.Add(ac);
                }
            }
            var account = data.Select(p => new{ p.PersonID,p.Person.PersonName,p.Person.Role,p.Username,  p.Person.Address }) ; 
            return account.ToList();
        }
        public dynamic Fitler_Account(string value)
        {
            QLNS qLSPEntities = new QLNS();
            List<Account> data = new List<Account>();
            foreach (Account ac in qLSPEntities.Accounts.Select(p => p).ToList())
            {
                if (ac.Person.Role.Contains(value) == true || ac.Person.Address.Contains(value) == true)
                {
                    data.Add(ac);
                }
            }
            var account = data.Select(p => new { p.PersonID, p.Person.PersonName, p.Person.Role, p.Username, p.Person.Address });
            return account.ToList();
        }

        public dynamic SortAcount(string sortCategory, bool ascending)
        {
            QLNS qLSPEntities = new QLNS();
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
            if (sortCategory == "Address")
            {
                if (ascending)
                    data = qLSPEntities.Accounts.OrderBy(p => p.Person.Address).ToList();
                else
                    data = qLSPEntities.Accounts.OrderByDescending(p => p.Person.Address).ToList();
            }
            if (sortCategory == "Role")
            {
                if (ascending)
                    data = qLSPEntities.Accounts.OrderBy(p => p.Person.Role).ToList();
                else
                    data = qLSPEntities.Accounts.OrderByDescending(p => p.Person.Role).ToList();
            }
            var account = (data.Select(p => new { p.PersonID, p.Person.PersonName, p.Person.Role, p.Username, p.Person.Address })).ToList();
            return account;
        }
        public Account GetAccountByPersonID(string ID)
        {
            QLNS qLSPEntities = new QLNS();
            Account ac = qLSPEntities.Accounts.Find(ID);
            return ac;
        }
        public List<string> GetAllRole()
        {
            List<string> data = new List<string>();
            foreach (Account a in QLNS.Instance.Accounts.Select(p => p).ToList())
            {
                data.Add(a.Person.Role);
            }
            return data;
        }

        public List<string> GetAllAddress()
        {
            List<string> data = new List<string>();
            foreach (Account i in QLNS.Instance.Accounts.Select(p => p).ToList())
            {
                data.Add(i.Person.Address);
            }
            return data;
        }

        public void ChangePassword(string username, string newPassword)
        {
            Account acc = QLNS.Instance.Accounts.Find(username);
            acc.Password = newPassword;
            QLNS.Instance.SaveChanges();
        }

    }
 }

