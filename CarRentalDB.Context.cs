﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_Rental_App
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarRentalEntities : DbContext
    {
        public CarRentalEntities()
            : base("name=CarRentalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CarRentalRecord> CarRentalRecords { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<InsuranceComany> InsuranceComanies { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<State> States { get; set; }
    }
}
