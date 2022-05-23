using System;
using System.Data.Entity;
using System.Linq;
using PBL3.Model;

namespace PBL3
{
    public class QLNS : DbContext
    {
        // Your context has been configured to use a 'QLNS' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PBL3.QLNS' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLNS' 
        // connection string in the application configuration file.
        private static QLNS _instance;
        public static QLNS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QLNS();
                }
                return _instance;
            }
            private set
            {

            }
        }

        public QLNS()
            : base("name=QLNS")
        {
            Database.SetInitializer<QLNS>(new CreateDB());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<Restock> Restocks { get; set; }
        public virtual DbSet<RestockDetail> RestockDetails { get; set; }
        public virtual DbSet<StoreImport> StoreImports { get; set; }
        public virtual DbSet<StoreImportDetail> StoreImportDetails { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}