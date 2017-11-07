using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseFactory dbfactory;
        private MyFinalsContext ctx;
        public UnitOfWork(DatabaseFactory dbFactory)
        {
            this.dbfactory = dbFactory;
            ctx = dbfactory.Mycontext;

        }

        public MyFinalsContext Ctx
        {
            get { return ctx; }
        }

        public void Dispose()
        {
            if (Ctx != null)
            {
                Ctx.Dispose();
            }
        }
        public void commit()
        {
            ctx.SaveChanges();
        }

        public RespositoryBase<T> GetRepository<T>() where T : class
        {
            return new RespositoryBase<T>(dbfactory);
        }
    }
}
