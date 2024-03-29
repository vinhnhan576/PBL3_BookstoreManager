﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

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

        public List<Person> GetAllPeople()
        {
            List<Person> people = new List<Person>();
            foreach (Person person in QLNS.Instance.People.ToList())
            {
                people.Add(person);
            }
            return people;
        }
        public void AddNewPerson(Person ps)
        {
            QLNS qLSPEntities = new QLNS();
            qLSPEntities.People.Add(ps);
            qLSPEntities.SaveChanges();
        }
        public void DelPerson(List<string> ID)
        {
            QLNS qLSPEntities = new QLNS();
            foreach (string i in ID)
            {
                Account ac = qLSPEntities.Accounts.Find(i);
                qLSPEntities.Accounts.Remove(ac);
                qLSPEntities.SaveChanges();
            }
        }

        public Person GetPersonByPersonID(string personID)
        {
            return QLNS.Instance.People.Find(personID);
        }

        public void UpdatePeronalInfo(string personID, Person newPerson)
        {
            Person p = GetPersonByPersonID(personID);
            p.PersonName = newPerson.PersonName;
            p.Address = newPerson.Address;
            p.PhoneNumber = newPerson.PhoneNumber;
            p.Email = newPerson.Email;
            p.Gender = newPerson.Gender;
            QLNS.Instance.SaveChanges();
        }

        public bool CheckEmail(string email)
        {
            foreach(Person i in QLNS.Instance.People)
            {
                if (i.Email != null)
                {
                    if (i.Email.Trim() == email)
                        return true;
                }
            }
            return false;
        }

        public Person GetPersonByEmail(string email)
        {
            foreach (Person i in QLNS.Instance.People)
            {
                if (i.Email != null)
                {
                    if (i.Email.Trim() == email)
                        return i;
                }
            }
            return null;
        }
    }
}
