﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.SQLDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections;
    
    public partial class CardEntities : DbContext
    {
        public CardEntities()
            : base("name=CardDBEntities")
        {
            this.Configuration.ProxyCreationEnabled = false; 
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CardTable> CardTables { get; set; }

        public virtual ObjectResult<CardTable> GetCardInfobyNumber(string cardNo)
        {
            var cardNoParameter = cardNo != null ?
                new ObjectParameter("CardNo", cardNo) :
                new ObjectParameter("CardNo", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CardTable>("GetCardInfobyNumber", cardNoParameter);
        }    
    }
}
