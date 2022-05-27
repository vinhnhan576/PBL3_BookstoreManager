﻿using System;
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



            //context.Accounts.AddRange(new Account[]
            //{
            //    new Account { PersonID = "ad01", Username = "ad01", Password = "123456" },
            //    new Account { PersonID = "sm01", Username = "sm01", Password = "123456" },
            //});



            context.People.AddRange(new Person[]
            {
                new Person { PersonID = "ad01", PersonName = "Lê Văn Vĩnh Nhân", Address = "Huế", Email = "vinhnhan576@gmail.com", Gender = true, PhoneNumber = "0708182526", Role = "Admin" },
                new Person { PersonID = "sm01", PersonName = "Hoàng Thị Phương Uyên", Address = "Huế", Gender = false, PhoneNumber = "0708182526", Role = "Salesman" },
            });



            context.Products.AddRange(new Product[]
            {
                new Product { ProductID = "p001", ProductName = "Diary of a wimpy kid", Category = "Realistic Fiction" , SellingPrice = 50000},
            });



            context.Ranks.AddRange(new Rank[]
            {
                new Rank { RankID = "r0", RankName = "Unranked", Requirement = 0, CustomerDiscount = 0 },
                new Rank { RankID = "r1", RankName = "Bronze", Requirement = 200000, CustomerDiscount = 20000 },
            });



            context.Customers.AddRange(new Customer[]
            {
                new Customer { PhoneNumber = "0123456789", CustomerName = "Le Van Dat", RankID = "r1", TotalSpending = 0 },
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