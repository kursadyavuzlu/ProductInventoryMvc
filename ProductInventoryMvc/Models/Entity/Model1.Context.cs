﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductInventoryMvc.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Dbo_ProductInventoryEntities : DbContext
    {
        public Dbo_ProductInventoryEntities()
            : base("name=Dbo_ProductInventoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Categories> Tbl_Categories { get; set; }
        public virtual DbSet<Tbl_Customers> Tbl_Customers { get; set; }
        public virtual DbSet<Tbl_Products> Tbl_Products { get; set; }
        public virtual DbSet<Tbl_Sales> Tbl_Sales { get; set; }
    }
}