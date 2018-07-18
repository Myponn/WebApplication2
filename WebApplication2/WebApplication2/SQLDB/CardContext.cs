using System;
using System.Data;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.SQLDB
{
    public class CardContext:DbContext
    {
        public CardContext() : base("SqlServerEntities") { }

        public DbSet<CardInfo> cardInfo { get; set; }
    }
}