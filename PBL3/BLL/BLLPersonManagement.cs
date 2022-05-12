using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class BLLPersonManagement
    {
        private static BLLPersonManagement _instance;
        public static BLLPersonManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLPersonManagement();
                }
                return _instance;
            }
            private set
            {

            }
        }
        public void AddNewPerson(Person ps)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            qLSPEntities.People.Add(ps);
            qLSPEntities.SaveChanges();
        }
        public void DelPerson(List<string> ID)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            foreach (string i in ID)
            {
                Account ac = qLSPEntities.Accounts.Find(i);
                qLSPEntities.Accounts.Remove(ac);
                qLSPEntities.SaveChanges();
            }
        }
    }
}
