﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServicePattern
{
   public  interface IService<T>where T:class
    {
        void Create(T entity);
        void remove(T entity);
        T FindById(int id);
        T FindById(String id);
        void Update(T entity);  
        void Remove(Expression<Func<T, bool>> condition);
        IEnumerable<T> FindByCondition(
            Expression<Func<T, bool>> condition = null,
            Expression<Func<T, bool>> orederby = null);
        //IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null);
        void Commit();
    }
}
