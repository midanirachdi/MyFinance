﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructures
{
    public class RespositoryBase<T> : IRespositoryBase<T> where T : class
    {
        private MyFinalsContext ctx;//not exposed
        public MyFinalsContext MyContext { get { return ctx; } }
        private DbSet<T> dbset = null;
        public RespositoryBase(DatabaseFactory dbfactory)
        {
            ctx = dbfactory.Mycontext;
            dbset = ctx.Set<T>();
        }
        public void commit() { MyContext.SaveChanges(); }
        public void Create(T entity)
        {
            dbset.Add(entity);
        }

      /* public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orederby = null)
        {
            throw new NotImplementedException();
        }*/

        public T FindById(string id)
        {
            return dbset.Find(id);
        }

        public T FindById(int id)
        {
            return dbset.Find(id);
        }

        public void Remove(Expression<Func<T, bool>> condition)
        {
            IEnumerable<T> maListe = dbset.Where(condition);
            foreach (T item in maListe)
            {
                dbset.Remove(item);
            }
        }

        public void remove(T entity)
        {
            dbset.Remove(entity);
        }

        public void Update(T entity)
        {
            //attacher lentite au dbset
            dbset.Attach(entity);
            //ecraser l'aancien objet par le nouveau
            MyContext.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> condition = null, 
                                              Expression<Func<T, bool>> orederby = null)
        {
            if (condition == null && orederby == null)
            {
                return dbset;
            }
            else
            if (condition != null && orederby == null)
            {
                return dbset.Where(condition);
            }
            else
            if (condition == null && orederby != null)
            {
                return dbset.OrderBy(orederby);
            }
            return dbset.Where(condition).OrderBy(orederby);
        }
       /* public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null)
        {
            IQueryable<T> Query = dbset;
            if (where != null)
            {
                Query = Query.Where(where);
            }
            if (orderBy != null)
            {
                Query = Query.OrderBy(orderBy);
            }
            return Query;
        }*/
    }
}
