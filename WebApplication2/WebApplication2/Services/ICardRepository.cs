using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace WebApplication2.Services
{
    public interface ICardRepository<T>
    {
        T GetData(Specification<T> Spec);
        void Add(T Entity);
    }

    public interface Specification<T>
    {
        Expression<Func<T, bool>> TSpec{get;}
        bool isStisfy(T Obj);
    }
}