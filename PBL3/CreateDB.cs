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
                new Person { PersonID = "ad01", PersonName = "Lê Văn Vĩnh Nhân", Address = "Huế", Email = "vinhnhan576@gmail.com", Gender = true, PhoneNumber = "0708182526", Role = "Admin" },
                new Person { PersonID = "sm01", PersonName = "Hoàng Thị Phương Uyên", Address = "Huế", Gender = false, PhoneNumber = "0123456789", Role = "Salesman" },
                new Person { PersonID = "sk01", PersonName = "Trần Thanh Bình", Address = "Quảng Trị", Gender = true, PhoneNumber = "0987654321", Role = "Stockkeeper" },
            });

            context.Accounts.AddRange(new Account[]
            {
                new Account { PersonID = "ad01", Username = "ad01", Password = "123456" },
                new Account { PersonID = "sm01", Username = "sm01", Password = "123456" },
                new Account { PersonID = "sk01", Username = "sk01", Password = "123456" },
            });

            context.Products.AddRange(new Product[]
            {
                new Product { ProductID = "p001", ProductName = "Diary of a wimpy kid", Category = "Realistic Fiction" , SellingPrice = 45000},
                new Product { ProductID = "p002", ProductName = "Diary of a wimpy kid: Hard Luck", Category = "Realistic Fiction" , SellingPrice = 50000},
                new Product { ProductID = "p003", ProductName = "Percy Jackson and the Olympians: The Lightning Thief", Category = "Mythological Adventure Fiction" , SellingPrice = 180000},
                new Product { ProductID = "p004", ProductName = "Percy Jackson and the Olympians: The Sea of Monsters", Category = "Mythological Adventure Fiction" , SellingPrice = 133000},
                new Product { ProductID = "p005", ProductName = "Percy Jackson and the Olympians: The Titan's Curse", Category = "Mythological Adventure Fiction" , SellingPrice = 139000},
                new Product { ProductID = "p006", ProductName = "Percy Jackson and the Olympians: The Battle of the Labyrinth", Category = "Mythological Adventure Fiction" , SellingPrice = 175000},
                new Product { ProductID = "p007", ProductName = "Percy Jackson and the Olympians: The Last Olympian", Category = "Mythological Adventure Fiction" , SellingPrice = 161000},
            });



            context.Ranks.AddRange(new Rank[]
            {
                new Rank { RankID = "r0", RankName = "Unranked", Requirement = 0, CustomerDiscount = 0 },
                new Rank { RankID = "r1", RankName = "Bronze", Requirement = 500000, CustomerDiscount = 20000 },
                new Rank { RankID = "r2", RankName = "Silver", Requirement = 700000, CustomerDiscount = 40000 },
                new Rank { RankID = "r3", RankName = "Gold", Requirement = 1000000, CustomerDiscount = 50000 },
                new Rank { RankID = "r4", RankName = "Platinum", Requirement = 2000000, CustomerDiscount = 100000 },
                new Rank { RankID = "r5", RankName = "Diamond", Requirement = 5000000, CustomerDiscount = 200000 },
            });



            context.Customers.AddRange(new Customer[]
            {
                new Customer { PhoneNumber = "0147258369", CustomerName = "Le Van Dat", RankID = "r0", TotalSpending = 0 },
            });



            //context.Restocks.AddRange(new Restock[]
            //{
            //    new Restock { RestockID = "1", ImportDate = DateTime.Now, PersonID = "sm01" },
            //});



            //context.RestockDetails.AddRange(new RestockDetail[]
            //{
            //    new RestockDetail { RestockID = "1", RestockDetailID = "1", ProductID = "p001", ImportQuantity = 100, ImportPrice = 45000},
            //});



            //context.StoreImports.AddRange(new StoreImport[]
            //{
            //    new StoreImport { ImportDate = DateTime.Now, StoreImportID = "1", },
            //});



            //context.StoreImportDetails.AddRange(new StoreImportDetail[]
            //{
            //    new StoreImportDetail { StoreImportID = "1", StoreImportDetailID = "1", ProductID = "p001", ImportQuantity = 20 },
            //});



            //context.Receipts.AddRange(new Receipt[]
            //{
            //    new Receipt { ReceiptID = "rpt1", Date = new DateTime(2022, 5, 21), Total = 56000, PersonID = "sm01", PhoneNumber = "0123456789" },
            //});



            //context.ReceiptDetails.AddRange(new ReceiptDetail[]
            //{
            //    new ReceiptDetail { ReceiptID = "rpt1", ReceiptDetailID = "101", ProductID = "p001", SellingQuantity = 2, Total = 100000},
            //});
        }
    }
}