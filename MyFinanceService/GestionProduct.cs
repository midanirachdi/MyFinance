using MyFinance.Domain.Entites;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Data.Infrastructures;

namespace MyFinanceService
{
    public class GestionProduct : Service<Product>, IGestionProduct
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        static UnitOfWork utw = new UnitOfWork(dbFactory);
        
        public GestionProduct() : base(utw)
        {
        }

        public IEnumerable<Product> ListerProductByCategoryIn2008(string name)
        {
            return utw.GetRepository<Product>().FindByCondition(x=>x.MyCategory.NameCategory==name).Where(x=>x.DateProd.Year==2008);
        }
    }
}
