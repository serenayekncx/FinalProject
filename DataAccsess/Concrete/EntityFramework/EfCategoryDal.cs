using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{  //NuGet
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category Entity)
        {
            throw new NotImplementedException();
        }

       
        public List<Product> Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category Entity)
        {
            throw new NotImplementedException();
        }
    }
}
