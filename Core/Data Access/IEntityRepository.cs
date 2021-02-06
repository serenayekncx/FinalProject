using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // GENERİC CONSTRAİNT
    //CLASS : REFERNS TİP OLABİLİR DEMEK 
    //ıentity olabilir veya ıentity implemente eden bir tip olabilir
    //new() : newlenebilir olmalı demek
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
