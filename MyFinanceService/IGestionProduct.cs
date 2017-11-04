using MyFinance.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePattern;

namespace MyFinanceService
{
   public interface IGestionProduct:IService<Product>
    {
        IEnumerable<Product> ListerProductByCategoryIn2008(String name);
    }
}
