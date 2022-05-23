using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

namespace PBL3
{
    internal class CreateDB : DropCreateDatabaseIfModelChanges<QLNS>
    {
        protected override void Seed(QLNS context)
        {
            context.People.AddRange(new Person[]
            {
                new Person { PersonID = "ad01", PersonName = "Lê Văn Vĩnh Nhân" },
                new Person { PersonID = "sm01", PersonName = "Hoàng Thị Phương Uyên" },
            });

            context.Accounts.AddRange(new Account[]
            {
                new Account { PersonID = "ad01", Username = "ad01", Password = "123456" },
                new Account { PersonID = "sm01", Username = "sm01", Password = "123456" },
            });
        }
    }
}