﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_MVC5.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Demo_onlineEntities : DbContext
    {
        public Demo_onlineEntities()
            : base("name=Demo_onlineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_order> tb_order { get; set; }
        public virtual DbSet<tb_Product> tb_Product { get; set; }
        public virtual DbSet<tb_order_detail> tb_order_detail { get; set; }
        public virtual DbSet<tb_Cart> tb_Cart { get; set; }
        public virtual DbSet<tb_Supplier> tb_Supplier { get; set; }
        public virtual DbSet<tb_SalesOrder> tb_SalesOrder { get; set; }
        public virtual DbSet<tb_Sales> tb_Sales { get; set; }
    }
}
