﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLSPEntities : DbContext
    {
        private static QLSPEntities instance;
        public static QLSPEntities Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLSPEntities();
                return instance;
            }
            private set { }
        }
        public QLSPEntities()
            : base("name=QLSPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Receipt_Detail> Receipt_Details { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<RestockDetail> RestockDetails { get; set; }
        public virtual DbSet<StoreImportDetail> StoreImportDetails { get; set; }
        public virtual DbSet<Restock> Restocks { get; set; }
        public virtual DbSet<Store_Import> Store_Imports { get; set; }
    }
}
