using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Services;
using WebApplication2.Models;

namespace WebApplication2.SQLDB
{
    public class DBRepository<T> : ICardRepository<T>
    {
        protected static List<T> Entities = new List<T>();

        public T GetData(Specification<T> Spec)
        {
            return Entities.Where(Spec.isStisfy).FirstOrDefault();
        }

        public void Add(T Entity)
        {
            Entities.Add(Entity);
        }
    }

    
}