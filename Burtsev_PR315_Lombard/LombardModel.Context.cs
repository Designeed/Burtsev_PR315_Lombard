﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Burtsev_PR315_Lombard
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LombardEntities : DbContext
    {
        public LombardEntities()
            : base("name=LombardEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GraphPayStatu> GraphPayStatus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProdutSell> ProdutSells { get; set; }
        public virtual DbSet<TypeProdut> TypeProduts { get; set; }
        public virtual DbSet<TypeStatu> TypeStatus { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Workman> Workmen { get; set; }
    }
}
