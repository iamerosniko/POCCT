﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrontEnd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbbtCalTEntities : DbContext
    {
        public dbbtCalTEntities()
            : base("name=dbbtCalTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CTD_CallCategories> CTD_CallCategories { get; set; }
        public virtual DbSet<CTD_CallerAssocs> CTD_CallerAssocs { get; set; }
        public virtual DbSet<CTD_Calls> CTD_Calls { get; set; }
        public virtual DbSet<CTD_CallStatuses> CTD_CallStatuses { get; set; }
        public virtual DbSet<set_group> set_group { get; set; }
        public virtual DbSet<set_module> set_module { get; set; }
        public virtual DbSet<set_user> set_user { get; set; }
    }
}
